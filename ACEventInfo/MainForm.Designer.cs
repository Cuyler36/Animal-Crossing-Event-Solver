namespace ACEventInfo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Event1DateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Event2DateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Event3DateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Event1ComboBox = new System.Windows.Forms.ComboBox();
            this.Event2ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Event3ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WeekdayDateTime = new System.Windows.Forms.DateTimePicker();
            this.GulliverSpawnDateTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.PIDButton = new System.Windows.Forms.Button();
            this.PrevEventComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DesiredEventComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ResultEventDateTime = new System.Windows.Forms.DateTimePicker();
            this.GulliverButton = new System.Windows.Forms.Button();
            this.SpecialEventButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SearchDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Event1DateTime
            // 
            this.Event1DateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.Event1DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Event1DateTime.Location = new System.Drawing.Point(12, 25);
            this.Event1DateTime.Name = "Event1DateTime";
            this.Event1DateTime.Size = new System.Drawing.Size(200, 20);
            this.Event1DateTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event #1 Date && Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event #2 Date && Time";
            // 
            // Event2DateTime
            // 
            this.Event2DateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.Event2DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Event2DateTime.Location = new System.Drawing.Point(12, 64);
            this.Event2DateTime.Name = "Event2DateTime";
            this.Event2DateTime.Size = new System.Drawing.Size(200, 20);
            this.Event2DateTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event #3 Date && Time";
            // 
            // Event3DateTime
            // 
            this.Event3DateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.Event3DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Event3DateTime.Location = new System.Drawing.Point(12, 103);
            this.Event3DateTime.Name = "Event3DateTime";
            this.Event3DateTime.Size = new System.Drawing.Size(200, 20);
            this.Event3DateTime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Event #1";
            // 
            // Event1ComboBox
            // 
            this.Event1ComboBox.FormattingEnabled = true;
            this.Event1ComboBox.Items.AddRange(new object[] {
            "Wendell",
            "Redd",
            "Gracie",
            "Katrina",
            "Nook Sale",
            "Saharah"});
            this.Event1ComboBox.Location = new System.Drawing.Point(218, 25);
            this.Event1ComboBox.Name = "Event1ComboBox";
            this.Event1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Event1ComboBox.TabIndex = 7;
            // 
            // Event2ComboBox
            // 
            this.Event2ComboBox.FormattingEnabled = true;
            this.Event2ComboBox.Items.AddRange(new object[] {
            "Wendell",
            "Redd",
            "Gracie",
            "Katrina",
            "Nook Sale",
            "Saharah"});
            this.Event2ComboBox.Location = new System.Drawing.Point(218, 63);
            this.Event2ComboBox.Name = "Event2ComboBox";
            this.Event2ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Event2ComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Event #2";
            // 
            // Event3ComboBox
            // 
            this.Event3ComboBox.FormattingEnabled = true;
            this.Event3ComboBox.Items.AddRange(new object[] {
            "Wendell",
            "Redd",
            "Gracie",
            "Katrina",
            "Nook Sale",
            "Saharah"});
            this.Event3ComboBox.Location = new System.Drawing.Point(218, 103);
            this.Event3ComboBox.Name = "Event3ComboBox";
            this.Event3ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Event3ComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Event #3";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(560, 2);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gulliver";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "1st Weekday Date && Time";
            // 
            // WeekdayDateTime
            // 
            this.WeekdayDateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.WeekdayDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WeekdayDateTime.Location = new System.Drawing.Point(12, 233);
            this.WeekdayDateTime.Name = "WeekdayDateTime";
            this.WeekdayDateTime.Size = new System.Drawing.Size(200, 20);
            this.WeekdayDateTime.TabIndex = 14;
            // 
            // GulliverSpawnDateTime
            // 
            this.GulliverSpawnDateTime.Enabled = false;
            this.GulliverSpawnDateTime.Location = new System.Drawing.Point(218, 233);
            this.GulliverSpawnDateTime.Name = "GulliverSpawnDateTime";
            this.GulliverSpawnDateTime.Size = new System.Drawing.Size(200, 20);
            this.GulliverSpawnDateTime.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Spawn Date";
            // 
            // PIDButton
            // 
            this.PIDButton.Location = new System.Drawing.Point(12, 129);
            this.PIDButton.Name = "PIDButton";
            this.PIDButton.Size = new System.Drawing.Size(327, 23);
            this.PIDButton.TabIndex = 18;
            this.PIDButton.Text = "Solve PIDs";
            this.PIDButton.UseVisualStyleBackColor = true;
            this.PIDButton.Click += new System.EventHandler(this.PIDButton_Click);
            // 
            // PrevEventComboBox
            // 
            this.PrevEventComboBox.FormattingEnabled = true;
            this.PrevEventComboBox.Items.AddRange(new object[] {
            "Wendell",
            "Redd",
            "Gracie",
            "Katrina",
            "Nook Sale",
            "Saharah"});
            this.PrevEventComboBox.Location = new System.Drawing.Point(372, 25);
            this.PrevEventComboBox.Name = "PrevEventComboBox";
            this.PrevEventComboBox.Size = new System.Drawing.Size(98, 21);
            this.PrevEventComboBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Last Event";
            // 
            // DesiredEventComboBox
            // 
            this.DesiredEventComboBox.FormattingEnabled = true;
            this.DesiredEventComboBox.Items.AddRange(new object[] {
            "Wendell",
            "Redd",
            "Gracie",
            "Katrina",
            "Nook Sale",
            "Saharah"});
            this.DesiredEventComboBox.Location = new System.Drawing.Point(476, 24);
            this.DesiredEventComboBox.Name = "DesiredEventComboBox";
            this.DesiredEventComboBox.Size = new System.Drawing.Size(96, 21);
            this.DesiredEventComboBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(473, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Desired Event";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Result Date-Time";
            // 
            // ResultEventDateTime
            // 
            this.ResultEventDateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.ResultEventDateTime.Enabled = false;
            this.ResultEventDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ResultEventDateTime.Location = new System.Drawing.Point(372, 104);
            this.ResultEventDateTime.Name = "ResultEventDateTime";
            this.ResultEventDateTime.Size = new System.Drawing.Size(200, 20);
            this.ResultEventDateTime.TabIndex = 23;
            // 
            // GulliverButton
            // 
            this.GulliverButton.Location = new System.Drawing.Point(12, 259);
            this.GulliverButton.Name = "GulliverButton";
            this.GulliverButton.Size = new System.Drawing.Size(406, 23);
            this.GulliverButton.TabIndex = 25;
            this.GulliverButton.Text = "Solve Gulliver";
            this.GulliverButton.UseVisualStyleBackColor = true;
            this.GulliverButton.Click += new System.EventHandler(this.GulliverButton_Click);
            // 
            // SpecialEventButton
            // 
            this.SpecialEventButton.Enabled = false;
            this.SpecialEventButton.Location = new System.Drawing.Point(372, 129);
            this.SpecialEventButton.Name = "SpecialEventButton";
            this.SpecialEventButton.Size = new System.Drawing.Size(200, 23);
            this.SpecialEventButton.TabIndex = 26;
            this.SpecialEventButton.Text = "Solve Special Event";
            this.SpecialEventButton.UseVisualStyleBackColor = true;
            this.SpecialEventButton.Click += new System.EventHandler(this.SpecialEventButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Search Start Date";
            // 
            // SearchDateTime
            // 
            this.SearchDateTime.CustomFormat = "ddd MM/dd/yyyy HH:mm:ss";
            this.SearchDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchDateTime.Location = new System.Drawing.Point(372, 65);
            this.SearchDateTime.Name = "SearchDateTime";
            this.SearchDateTime.Size = new System.Drawing.Size(200, 20);
            this.SearchDateTime.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 296);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SearchDateTime);
            this.Controls.Add(this.SpecialEventButton);
            this.Controls.Add(this.GulliverButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ResultEventDateTime);
            this.Controls.Add(this.DesiredEventComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PrevEventComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PIDButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GulliverSpawnDateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WeekdayDateTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Event3ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Event2ComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Event1ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Event3DateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Event2DateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Event1DateTime);
            this.Name = "Form1";
            this.Text = "AC Event Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Event1DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Event2DateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Event3DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Event1ComboBox;
        private System.Windows.Forms.ComboBox Event2ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Event3ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker WeekdayDateTime;
        private System.Windows.Forms.DateTimePicker GulliverSpawnDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button PIDButton;
        private System.Windows.Forms.ComboBox PrevEventComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DesiredEventComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ResultEventDateTime;
        private System.Windows.Forms.Button GulliverButton;
        private System.Windows.Forms.Button SpecialEventButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker SearchDateTime;
    }
}

