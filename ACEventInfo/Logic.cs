using System;
using System.Collections.Generic;

namespace ACEventInfo
{
    /// <summary>
    /// Enum of special event types with their corresponding in-game event ids.
    /// </summary>
    public enum SpecialEventType : int
    {
        Wendell = 0x4A,
        Redd = 0x4B,
        Gracie = 0x4C,
        Katrina = 0x4D,
        NookSale = 0x4E,
        Saharah = 0x4F
    }

    /// <summary>
    /// Struct used to compact Event Type & Date-Time.
    /// </summary>
    public struct SpecialEventInfo
    {
        /// <summary>
        /// The type of event.
        /// </summary>
        public SpecialEventType Type;

        /// <summary>
        /// The Date-Time which it will spawn. Currently unused.
        /// </summary>
        public DateTime Date;
    }

    internal static class Logic
    {
        /// <summary>
        /// Solves when Gulliver will spawn in a given week.
        /// </summary>
        /// <param name="year">The year of the first weekday played in the week.</param>
        /// <param name="month">The month of the first weekday played in the week.</param>
        /// <param name="day">The day of the first weekday played in the week.</param>
        /// <param name="hour">The hour during load of the first weekday played in the week.</param>
        /// <returns>DateTime spawnDate</returns>
        public static DateTime SolveGulliver(int year, int month, int day, int hour)
        {
            // 5 week days in a week.
            const int NUM_WEEK_DAYS = 5;

            // Sunday = 0, Monday = 1, Monday is also first day of weekdays.
            const int DAY_MONDAY = 1;

            // Main logic. Quite simple. Concatenate the month shifted left 8 bits (equal to month * 256) and OR that with the day, add the hour, and take modulus 5 of that.
            // Add one (for starting on Monday), and subtract the day of the week (0-6, Sunday-Saturday) from the result.
            DateTime temp = new DateTime(year, month, day);
            return temp.AddDays((((((month << 8) | day) + hour) % NUM_WEEK_DAYS) + DAY_MONDAY) - (int)temp.DayOfWeek);
        }

        /// <summary>
        /// Clone of internal special event types array used for solving.
        /// </summary>
        private static readonly SpecialEventType[] special_event_types =
        {
            SpecialEventType.NookSale, SpecialEventType.Gracie, SpecialEventType.Redd, SpecialEventType.Wendell, SpecialEventType.Saharah, SpecialEventType.Katrina
        };

        /// <summary>
        /// Solves what type the next special event will be.
        /// </summary>
        /// <param name="pid">A PID that solves the set for the current Player's PID. Repeats in increments of 6, so any PID in the set will work.</param>
        /// <param name="year">The year the player is loading in at.</param>
        /// <param name="month">The month the player is loading in at.</param>
        /// <param name="day">The day the player is loading in at.</param>
        /// <param name="hour">The hour the player is loading in at.</param>
        /// <param name="lastType">The last special event rolled.</param>
        /// <returns>SpecialEventType newEvent</returns>
        private static SpecialEventType SolveSpecialEventType(ushort pid, int year, int month, int day, int hour, SpecialEventType lastType)
        {
            int roll = pid + 1 + (year - month) + (day + hour);
            SpecialEventType newType;
            do
            {
                newType = special_event_types[roll % special_event_types.Length];
                roll++;
            } while (lastType == newType);
            return newType;
        }

        /// <summary>
        /// Solves for the set of PIDs that will roll the given list of events at the given times.
        /// </summary>
        /// <param name="previousEvents">Array of previous special events.</param>
        /// <param name="previousTimes">Array of previous date-times the events were spawned at.</param>
        /// <returns>List<ushort> pidList</returns>
        public static List<ushort> SolvePID(in SpecialEventType[] previousEvents, in DateTime[] previousTimes)
        {
            const ushort PID_MAX = 0xF0FD;
            List<ushort> candidiates = new List<ushort>();
            for (ushort i = 0xF000; i < PID_MAX; i++)
            {
                bool valid = true;
                for (int x = 1; x < previousEvents.Length; x++)
                {
                    DateTime t = previousTimes[x];
                    if (SolveSpecialEventType(i, t.Year, t.Month, t.Day, t.Hour, previousEvents[x - 1]) != previousEvents[x])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                    candidiates.Add(i);
            }

            return candidiates;
        }

        /// <summary>
        /// Solves what the next special event will be for a given load time. Currently unused.
        /// </summary>
        /// <param name="pid">A PID for the set.</param>
        /// <param name="year">Current year of the game during load.</param>
        /// <param name="month">Current month of the game during load.</param>
        /// <param name="day">Current day of the game during load.</param>
        /// <param name="hour">Current hour of the game during load.</param>
        /// <param name="last">The previously rolled special event.</param>
        /// <returns>SpecialEventInfo newInfo</returns>
        public static SpecialEventInfo SolveSpecialEvent(ushort pid, int year, int month, int day, int hour, SpecialEventType last)
        {
            return new SpecialEventInfo { Type = SolveSpecialEventType(pid, year, month, day, hour, last) };
        }

        /// <summary>
        /// Solves for a date-time in the future which will guarantee a desired event spawns that week.
        /// Note that the same event CANNOT occur twice in a row due to game logic. E.g. you can't roll Gracie two spawns in a row.
        /// </summary>
        /// <param name="pid">A PID from the set of PIDs which will solve the event.</param>
        /// <param name="current">The current Date-Time. Only year, month, day, and hour are required for the type.</param>
        /// <param name="last">The last event type rolled.</param>
        /// <param name="desired">The desired event type.</param>
        /// <returns>DateTime desiredEventDateTimeSeed</returns>
        public static DateTime SolveDesiredEventDateTime(ushort pid, DateTime current, SpecialEventType last, SpecialEventType desired)
        {
            SpecialEventType result;
            do
            {
                result = SolveSpecialEventType(pid, current.Year, current.Month, current.Day, current.Hour, last);
                if (result != desired) current.AddHours(1);
            } while (result != desired);
            return current;
        }
    }
}
