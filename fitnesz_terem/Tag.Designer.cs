namespace fitnesz_terem
{
    partial class Tag
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.Classes_Listbox = new System.Windows.Forms.ListBox();
            this.Times_Listbox = new System.Windows.Forms.ListBox();
            this.Details_GroupBox = new System.Windows.Forms.GroupBox();
            this.JoinedAndMax_Label = new System.Windows.Forms.Label();
            this.EndTime_Label = new System.Windows.Forms.Label();
            this.StartTime_Label = new System.Windows.Forms.Label();
            this.ClassName_Label = new System.Windows.Forms.Label();
            this.ClassID_Label = new System.Windows.Forms.Label();
            this.CoachName_Label = new System.Windows.Forms.Label();
            this.Details_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(349, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.AutoSize = true;
            this.SelectedDateLabel.Location = new System.Drawing.Point(17, 7);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.Size = new System.Drawing.Size(72, 15);
            this.SelectedDateLabel.TabIndex = 1;
            this.SelectedDateLabel.Text = "-------------";
            // 
            // Classes_Listbox
            // 
            this.Classes_Listbox.FormattingEnabled = true;
            this.Classes_Listbox.ItemHeight = 15;
            this.Classes_Listbox.Location = new System.Drawing.Point(579, 18);
            this.Classes_Listbox.Name = "Classes_Listbox";
            this.Classes_Listbox.Size = new System.Drawing.Size(120, 154);
            this.Classes_Listbox.TabIndex = 2;
            this.Classes_Listbox.SelectedIndexChanged += new System.EventHandler(this.Classes_Listbox_SelectedIndexChanged);
            // 
            // Times_Listbox
            // 
            this.Times_Listbox.FormattingEnabled = true;
            this.Times_Listbox.ItemHeight = 15;
            this.Times_Listbox.Location = new System.Drawing.Point(746, 18);
            this.Times_Listbox.Name = "Times_Listbox";
            this.Times_Listbox.Size = new System.Drawing.Size(120, 154);
            this.Times_Listbox.TabIndex = 3;
            this.Times_Listbox.SelectedIndexChanged += new System.EventHandler(this.Times_Listbox_SelectedIndexChanged);
            // 
            // Details_GroupBox
            // 
            this.Details_GroupBox.Controls.Add(this.CoachName_Label);
            this.Details_GroupBox.Controls.Add(this.JoinedAndMax_Label);
            this.Details_GroupBox.Controls.Add(this.EndTime_Label);
            this.Details_GroupBox.Controls.Add(this.StartTime_Label);
            this.Details_GroupBox.Controls.Add(this.ClassName_Label);
            this.Details_GroupBox.Controls.Add(this.ClassID_Label);
            this.Details_GroupBox.Location = new System.Drawing.Point(777, 238);
            this.Details_GroupBox.Name = "Details_GroupBox";
            this.Details_GroupBox.Size = new System.Drawing.Size(200, 137);
            this.Details_GroupBox.TabIndex = 4;
            this.Details_GroupBox.TabStop = false;
            this.Details_GroupBox.Text = "groupBox1";
            // 
            // JoinedAndMax_Label
            // 
            this.JoinedAndMax_Label.AutoSize = true;
            this.JoinedAndMax_Label.Location = new System.Drawing.Point(15, 81);
            this.JoinedAndMax_Label.Name = "JoinedAndMax_Label";
            this.JoinedAndMax_Label.Size = new System.Drawing.Size(12, 15);
            this.JoinedAndMax_Label.TabIndex = 4;
            this.JoinedAndMax_Label.Text = "-";
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Location = new System.Drawing.Point(13, 63);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(12, 15);
            this.EndTime_Label.TabIndex = 3;
            this.EndTime_Label.Text = "-";
            // 
            // StartTime_Label
            // 
            this.StartTime_Label.AutoSize = true;
            this.StartTime_Label.Location = new System.Drawing.Point(13, 48);
            this.StartTime_Label.Name = "StartTime_Label";
            this.StartTime_Label.Size = new System.Drawing.Size(12, 15);
            this.StartTime_Label.TabIndex = 2;
            this.StartTime_Label.Text = "-";
            // 
            // ClassName_Label
            // 
            this.ClassName_Label.AutoSize = true;
            this.ClassName_Label.Location = new System.Drawing.Point(13, 33);
            this.ClassName_Label.Name = "ClassName_Label";
            this.ClassName_Label.Size = new System.Drawing.Size(12, 15);
            this.ClassName_Label.TabIndex = 1;
            this.ClassName_Label.Text = "-";
            // 
            // ClassID_Label
            // 
            this.ClassID_Label.AutoSize = true;
            this.ClassID_Label.Location = new System.Drawing.Point(13, 18);
            this.ClassID_Label.Name = "ClassID_Label";
            this.ClassID_Label.Size = new System.Drawing.Size(12, 15);
            this.ClassID_Label.TabIndex = 0;
            this.ClassID_Label.Text = "-";
            // 
            // CoachName_Label
            // 
            this.CoachName_Label.AutoSize = true;
            this.CoachName_Label.Location = new System.Drawing.Point(12, 99);
            this.CoachName_Label.Name = "CoachName_Label";
            this.CoachName_Label.Size = new System.Drawing.Size(12, 15);
            this.CoachName_Label.TabIndex = 5;
            this.CoachName_Label.Text = "-";
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 598);
            this.Controls.Add(this.Details_GroupBox);
            this.Controls.Add(this.Times_Listbox);
            this.Controls.Add(this.Classes_Listbox);
            this.Controls.Add(this.SelectedDateLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Tag";
            this.Text = "Tag";
            this.Load += new System.EventHandler(this.Tag_Load);
            this.Details_GroupBox.ResumeLayout(false);
            this.Details_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label SelectedDateLabel;
        private ListBox Classes_Listbox;
        private ListBox Times_Listbox;
        private GroupBox Details_GroupBox;
        private Label ClassID_Label;
        private Label ClassName_Label;
        private Label EndTime_Label;
        private Label StartTime_Label;
        private Label JoinedAndMax_Label;
        private Label CoachName_Label;
    }
}