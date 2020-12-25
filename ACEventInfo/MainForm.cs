using System;
using System.Windows.Forms;

namespace ACEventInfo
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Used to keep track of a PID seed that generates a correct set.
        /// </summary>
        private ushort eventSeedPID = 0;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PIDButton.Click event method.
        /// Solves for the set of PIDs which give us the correct special event set.
        /// Works in 3 consecutive rolls because log6(253) ~= 3. 6 special events, 253 possible PIDs.
        /// </summary>
        /// <param name="sender">Object which triggered the method event call.</param>
        /// <param name="e">Event args.</param>
        private void PIDButton_Click(object sender, EventArgs e)
        {
            if (Event1ComboBox.SelectedIndex == -1)
                MessageBox.Show("Please enter an event into Event #1");
            else if (Event2ComboBox.SelectedIndex == -1)
                MessageBox.Show("Please enter an event into Event #2");
            else if (Event3ComboBox.SelectedIndex == -1)
                MessageBox.Show("Please enter an event into Event #3");
            else
            {
                if (Event1ComboBox.SelectedIndex == Event2ComboBox.SelectedIndex)
                    MessageBox.Show("Event #1 and Event #2 cannot be the same event!");
                else if (Event2ComboBox.SelectedIndex == Event3ComboBox.SelectedIndex)
                    MessageBox.Show("Event #2 and Event #3 cannot be the same event!");
                else
                {
                    // Good to solve.
                    var pids = Logic.SolvePID(new SpecialEventType[] {
                        (SpecialEventType)(Event1ComboBox.SelectedIndex + 0x4A),
                        (SpecialEventType)(Event2ComboBox.SelectedIndex + 0x4A),
                        (SpecialEventType)(Event3ComboBox.SelectedIndex + 0x4A)
                    }, new DateTime[] { Event1DateTime.Value, Event2DateTime.Value, Event3DateTime.Value });
                    Console.WriteLine($"{pids[0]:X4}");
                    eventSeedPID = pids[0];
                    SpecialEventButton.Enabled = true;
                }
            }
        }

        /// <summary>
        /// SpecialEventButton.Click event method.
        /// Solves for the date-time required to start the game on for a desired event if the PID set is already known.
        /// </summary>
        /// <param name="sender">Object which triggered the method event call.</param>
        /// <param name="e">Event args.</param>
        private void SpecialEventButton_Click(object sender, EventArgs e)
        {
            if (eventSeedPID == 0) return;
            if (PrevEventComboBox.SelectedIndex == -1)
                MessageBox.Show("Please enter the last event that occurred.");
            else if (DesiredEventComboBox.SelectedIndex == -1)
                MessageBox.Show("Please enter a desired event.");
            else if (DesiredEventComboBox.SelectedIndex == PrevEventComboBox.SelectedIndex)
                MessageBox.Show("The previous event and desired event cannot be the same! Game logic prevents rolling the same event twice in a row.");
            else
            {
                ResultEventDateTime.Value =
                    Logic.SolveDesiredEventDateTime(eventSeedPID, SearchDateTime.Value, (SpecialEventType)(PrevEventComboBox.SelectedIndex + 0x4A), (SpecialEventType)(DesiredEventComboBox.SelectedIndex + 0x4A));
            }
        }

        /// <summary>
        /// GulliverButton.Click event method.
        /// Solves for the date which Gulliver will spawn on given the correct date-time of the first weekday played is correct.
        /// </summary>
        /// <param name="sender">Object which triggered the method event call.</param>
        /// <param name="e">Event args.</param>
        private void GulliverButton_Click(object sender, EventArgs e)
        {
            GulliverSpawnDateTime.Value = Logic.SolveGulliver(WeekdayDateTime.Value.Year, WeekdayDateTime.Value.Month, WeekdayDateTime.Value.Day, WeekdayDateTime.Value.Hour);
        }
    }
}
