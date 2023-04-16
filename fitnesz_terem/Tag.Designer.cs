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
            this.CoachName_Label = new System.Windows.Forms.Label();
            this.JoinedAndMax_Label = new System.Windows.Forms.Label();
            this.EndTime_Label = new System.Windows.Forms.Label();
            this.StartTime_Label = new System.Windows.Forms.Label();
            this.ClassName_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.edzésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.személyiEdzőhözJelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.értékelésKüldéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.órarendemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresesLabel = new System.Windows.Forms.Label();
            this.keresesPanel = new System.Windows.Forms.Panel();
            this.edzesre_Jelentkezes_Button = new System.Windows.Forms.Button();
            this.ertekelesPanel2 = new System.Windows.Forms.Panel();
            this.ertekeles_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Coaches_List = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.disclamerLabel = new System.Windows.Forms.Label();
            this.szemelyi_edzo_jelentkezesButton = new System.Windows.Forms.Button();
            this.szemelyi_edzo_keresesPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Details_GroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.keresesPanel.SuspendLayout();
            this.ertekelesPanel2.SuspendLayout();
            this.szemelyi_edzo_keresesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(516, 440);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.AutoSize = true;
            this.SelectedDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.SelectedDateLabel.ForeColor = System.Drawing.Color.White;
            this.SelectedDateLabel.Location = new System.Drawing.Point(840, 37);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.Size = new System.Drawing.Size(72, 15);
            this.SelectedDateLabel.TabIndex = 1;
            this.SelectedDateLabel.Text = "-------------";
            // 
            // Classes_Listbox
            // 
            this.Classes_Listbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.Classes_Listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Classes_Listbox.ForeColor = System.Drawing.Color.White;
            this.Classes_Listbox.FormattingEnabled = true;
            this.Classes_Listbox.ItemHeight = 25;
            this.Classes_Listbox.Location = new System.Drawing.Point(135, 66);
            this.Classes_Listbox.Name = "Classes_Listbox";
            this.Classes_Listbox.Size = new System.Drawing.Size(168, 179);
            this.Classes_Listbox.TabIndex = 2;
            this.Classes_Listbox.SelectedIndexChanged += new System.EventHandler(this.Classes_Listbox_SelectedIndexChanged);
            // 
            // Times_Listbox
            // 
            this.Times_Listbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Times_Listbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Times_Listbox.ForeColor = System.Drawing.Color.White;
            this.Times_Listbox.FormattingEnabled = true;
            this.Times_Listbox.ItemHeight = 25;
            this.Times_Listbox.Location = new System.Drawing.Point(378, 66);
            this.Times_Listbox.Name = "Times_Listbox";
            this.Times_Listbox.Size = new System.Drawing.Size(243, 179);
            this.Times_Listbox.TabIndex = 3;
            this.Times_Listbox.SelectedIndexChanged += new System.EventHandler(this.Times_Listbox_SelectedIndexChanged);
            // 
            // Details_GroupBox
            // 
            this.Details_GroupBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.Details_GroupBox.Controls.Add(this.CoachName_Label);
            this.Details_GroupBox.Controls.Add(this.JoinedAndMax_Label);
            this.Details_GroupBox.Controls.Add(this.EndTime_Label);
            this.Details_GroupBox.Controls.Add(this.StartTime_Label);
            this.Details_GroupBox.Controls.Add(this.ClassName_Label);
            this.Details_GroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Details_GroupBox.ForeColor = System.Drawing.Color.White;
            this.Details_GroupBox.Location = new System.Drawing.Point(189, 309);
            this.Details_GroupBox.Name = "Details_GroupBox";
            this.Details_GroupBox.Size = new System.Drawing.Size(301, 178);
            this.Details_GroupBox.TabIndex = 4;
            this.Details_GroupBox.TabStop = false;
            // 
            // CoachName_Label
            // 
            this.CoachName_Label.AutoSize = true;
            this.CoachName_Label.Location = new System.Drawing.Point(13, 129);
            this.CoachName_Label.Name = "CoachName_Label";
            this.CoachName_Label.Size = new System.Drawing.Size(20, 25);
            this.CoachName_Label.TabIndex = 5;
            this.CoachName_Label.Text = "-";
            // 
            // JoinedAndMax_Label
            // 
            this.JoinedAndMax_Label.AutoSize = true;
            this.JoinedAndMax_Label.Location = new System.Drawing.Point(13, 100);
            this.JoinedAndMax_Label.Name = "JoinedAndMax_Label";
            this.JoinedAndMax_Label.Size = new System.Drawing.Size(20, 25);
            this.JoinedAndMax_Label.TabIndex = 4;
            this.JoinedAndMax_Label.Text = "-";
            // 
            // EndTime_Label
            // 
            this.EndTime_Label.AutoSize = true;
            this.EndTime_Label.Location = new System.Drawing.Point(13, 72);
            this.EndTime_Label.Name = "EndTime_Label";
            this.EndTime_Label.Size = new System.Drawing.Size(20, 25);
            this.EndTime_Label.TabIndex = 3;
            this.EndTime_Label.Text = "-";
            // 
            // StartTime_Label
            // 
            this.StartTime_Label.AutoSize = true;
            this.StartTime_Label.Location = new System.Drawing.Point(13, 47);
            this.StartTime_Label.Name = "StartTime_Label";
            this.StartTime_Label.Size = new System.Drawing.Size(20, 25);
            this.StartTime_Label.TabIndex = 2;
            this.StartTime_Label.Text = "-";
            // 
            // ClassName_Label
            // 
            this.ClassName_Label.AutoSize = true;
            this.ClassName_Label.Location = new System.Drawing.Point(13, 22);
            this.ClassName_Label.Name = "ClassName_Label";
            this.ClassName_Label.Size = new System.Drawing.Size(20, 25);
            this.ClassName_Label.TabIndex = 1;
            this.ClassName_Label.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edzésekToolStripMenuItem,
            this.értékelésKüldéseToolStripMenuItem,
            this.órarendemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // edzésekToolStripMenuItem
            // 
            this.edzésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.személyiEdzőhözJelentkezésToolStripMenuItem,
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem});
            this.edzésekToolStripMenuItem.Name = "edzésekToolStripMenuItem";
            this.edzésekToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.edzésekToolStripMenuItem.Text = "edzések";
            // 
            // személyiEdzőhözJelentkezésToolStripMenuItem
            // 
            this.személyiEdzőhözJelentkezésToolStripMenuItem.Name = "személyiEdzőhözJelentkezésToolStripMenuItem";
            this.személyiEdzőhözJelentkezésToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.személyiEdzőhözJelentkezésToolStripMenuItem.Text = "személyi edzőhöz jelentkezés";
            this.személyiEdzőhözJelentkezésToolStripMenuItem.Click += new System.EventHandler(this.személyiEdzőhözJelentkezésToolStripMenuItem_Click);
            // 
            // csoportfoglalkozásraJelentkezésToolStripMenuItem
            // 
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem.Name = "csoportfoglalkozásraJelentkezésToolStripMenuItem";
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem.Text = "csoportfoglalkozásra jelentkezés";
            this.csoportfoglalkozásraJelentkezésToolStripMenuItem.Click += new System.EventHandler(this.csoportfoglalkozásraJelentkezésToolStripMenuItem_Click);
            // 
            // értékelésKüldéseToolStripMenuItem
            // 
            this.értékelésKüldéseToolStripMenuItem.Name = "értékelésKüldéseToolStripMenuItem";
            this.értékelésKüldéseToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.értékelésKüldéseToolStripMenuItem.Text = "értékelés küldése";
            this.értékelésKüldéseToolStripMenuItem.Click += new System.EventHandler(this.értékelésKüldéseToolStripMenuItem_Click);
            // 
            // órarendemToolStripMenuItem
            // 
            this.órarendemToolStripMenuItem.Name = "órarendemToolStripMenuItem";
            this.órarendemToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.órarendemToolStripMenuItem.Text = "órarendem";
            // 
            // keresesLabel
            // 
            this.keresesLabel.AutoSize = true;
            this.keresesLabel.BackColor = System.Drawing.Color.Transparent;
            this.keresesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.keresesLabel.ForeColor = System.Drawing.Color.White;
            this.keresesLabel.Location = new System.Drawing.Point(11, 12);
            this.keresesLabel.Name = "keresesLabel";
            this.keresesLabel.Size = new System.Drawing.Size(205, 32);
            this.keresesLabel.TabIndex = 6;
            this.keresesLabel.Text = "Elérhető edzések:";
            // 
            // keresesPanel
            // 
            this.keresesPanel.BackColor = System.Drawing.Color.Transparent;
            this.keresesPanel.Controls.Add(this.edzesre_Jelentkezes_Button);
            this.keresesPanel.Controls.Add(this.keresesLabel);
            this.keresesPanel.Controls.Add(this.Details_GroupBox);
            this.keresesPanel.Controls.Add(this.Times_Listbox);
            this.keresesPanel.Controls.Add(this.Classes_Listbox);
            this.keresesPanel.Controls.Add(this.monthCalendar1);
            this.keresesPanel.Location = new System.Drawing.Point(101, 37);
            this.keresesPanel.Name = "keresesPanel";
            this.keresesPanel.Size = new System.Drawing.Size(842, 614);
            this.keresesPanel.TabIndex = 7;
            // 
            // edzesre_Jelentkezes_Button
            // 
            this.edzesre_Jelentkezes_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edzesre_Jelentkezes_Button.Location = new System.Drawing.Point(141, 540);
            this.edzesre_Jelentkezes_Button.Name = "edzesre_Jelentkezes_Button";
            this.edzesre_Jelentkezes_Button.Size = new System.Drawing.Size(162, 42);
            this.edzesre_Jelentkezes_Button.TabIndex = 7;
            this.edzesre_Jelentkezes_Button.Text = "Jelentkezés";
            this.edzesre_Jelentkezes_Button.UseVisualStyleBackColor = true;
            this.edzesre_Jelentkezes_Button.Click += new System.EventHandler(this.edzesre_Jelentkezes_Button_Click);
            // 
            // ertekelesPanel2
            // 
            this.ertekelesPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ertekelesPanel2.Controls.Add(this.ertekeles_Button);
            this.ertekelesPanel2.Controls.Add(this.textBox2);
            this.ertekelesPanel2.Controls.Add(this.textBox1);
            this.ertekelesPanel2.Location = new System.Drawing.Point(147, 69);
            this.ertekelesPanel2.Name = "ertekelesPanel2";
            this.ertekelesPanel2.Size = new System.Drawing.Size(715, 304);
            this.ertekelesPanel2.TabIndex = 17;
            // 
            // ertekeles_Button
            // 
            this.ertekeles_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ertekeles_Button.Location = new System.Drawing.Point(518, 254);
            this.ertekeles_Button.Name = "ertekeles_Button";
            this.ertekeles_Button.Size = new System.Drawing.Size(121, 38);
            this.ertekeles_Button.TabIndex = 16;
            this.ertekeles_Button.Text = "Küldés";
            this.ertekeles_Button.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 132);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 127);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Értékelés...";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(15, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(649, 85);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Folyamatosan dolgozunk azon, hogy minél jobb környezetet biztosítsunk a vendégein" +
    "knek az edzéshez. Küldj visszajelzést az eddigi élményeiddel kapcsolatban, hogy " +
    "fejlődhessünk!";
            // 
            // Coaches_List
            // 
            this.Coaches_List.BackColor = System.Drawing.SystemColors.MenuText;
            this.Coaches_List.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Coaches_List.ForeColor = System.Drawing.Color.White;
            this.Coaches_List.FormattingEnabled = true;
            this.Coaches_List.ItemHeight = 25;
            this.Coaches_List.Location = new System.Drawing.Point(17, 80);
            this.Coaches_List.Name = "Coaches_List";
            this.Coaches_List.Size = new System.Drawing.Size(358, 204);
            this.Coaches_List.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Edzőink:";
            // 
            // disclamerLabel
            // 
            this.disclamerLabel.AutoSize = true;
            this.disclamerLabel.BackColor = System.Drawing.Color.Transparent;
            this.disclamerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disclamerLabel.ForeColor = System.Drawing.Color.White;
            this.disclamerLabel.Location = new System.Drawing.Point(17, 356);
            this.disclamerLabel.Name = "disclamerLabel";
            this.disclamerLabel.Size = new System.Drawing.Size(494, 21);
            this.disclamerLabel.TabIndex = 10;
            this.disclamerLabel.Text = "A magánóra időpontját  személyesen lehet az edzőkkel egyeztetni!";
            // 
            // szemelyi_edzo_jelentkezesButton
            // 
            this.szemelyi_edzo_jelentkezesButton.BackColor = System.Drawing.Color.White;
            this.szemelyi_edzo_jelentkezesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.szemelyi_edzo_jelentkezesButton.Location = new System.Drawing.Point(322, 296);
            this.szemelyi_edzo_jelentkezesButton.Name = "szemelyi_edzo_jelentkezesButton";
            this.szemelyi_edzo_jelentkezesButton.Size = new System.Drawing.Size(149, 42);
            this.szemelyi_edzo_jelentkezesButton.TabIndex = 11;
            this.szemelyi_edzo_jelentkezesButton.Text = "Jelentkezés";
            this.szemelyi_edzo_jelentkezesButton.UseVisualStyleBackColor = false;
            this.szemelyi_edzo_jelentkezesButton.Click += new System.EventHandler(this.szemelyi_edzo_jelentkezesButton_Click);
            // 
            // szemelyi_edzo_keresesPanel
            // 
            this.szemelyi_edzo_keresesPanel.BackColor = System.Drawing.Color.Transparent;
            this.szemelyi_edzo_keresesPanel.Controls.Add(this.szemelyi_edzo_jelentkezesButton);
            this.szemelyi_edzo_keresesPanel.Controls.Add(this.disclamerLabel);
            this.szemelyi_edzo_keresesPanel.Controls.Add(this.label1);
            this.szemelyi_edzo_keresesPanel.Controls.Add(this.Coaches_List);
            this.szemelyi_edzo_keresesPanel.Location = new System.Drawing.Point(61, 83);
            this.szemelyi_edzo_keresesPanel.Name = "szemelyi_edzo_keresesPanel";
            this.szemelyi_edzo_keresesPanel.Size = new System.Drawing.Size(645, 474);
            this.szemelyi_edzo_keresesPanel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fitnesz_terem.Properties.Resources.sotetbgr;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.keresesPanel);
            this.Controls.Add(this.ertekelesPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectedDateLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.szemelyi_edzo_keresesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tag";
            this.Text = "Tag";
            this.Load += new System.EventHandler(this.Tag_Load);
            this.Details_GroupBox.ResumeLayout(false);
            this.Details_GroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.keresesPanel.ResumeLayout(false);
            this.keresesPanel.PerformLayout();
            this.ertekelesPanel2.ResumeLayout(false);
            this.ertekelesPanel2.PerformLayout();
            this.szemelyi_edzo_keresesPanel.ResumeLayout(false);
            this.szemelyi_edzo_keresesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label SelectedDateLabel;
        private ListBox Classes_Listbox;
        private ListBox Times_Listbox;
        private GroupBox Details_GroupBox;
        private Label ClassName_Label;
        private Label EndTime_Label;
        private Label StartTime_Label;
        private Label JoinedAndMax_Label;
        private Label CoachName_Label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem edzésekToolStripMenuItem;
        private ToolStripMenuItem személyiEdzőhözJelentkezésToolStripMenuItem;
        private ToolStripMenuItem csoportfoglalkozásraJelentkezésToolStripMenuItem;
        private ToolStripMenuItem értékelésKüldéseToolStripMenuItem;
        private ToolStripMenuItem órarendemToolStripMenuItem;
        private Label keresesLabel;
        private Panel keresesPanel;
        private ListBox Coaches_List;
        private Label label1;
        private Label disclamerLabel;
        private Button szemelyi_edzo_jelentkezesButton;
        private Panel szemelyi_edzo_keresesPanel;
        private Label label2;
        private TextBox textBox1;
        private Panel ertekelesPanel2;
        private Button ertekeles_Button;
        private TextBox textBox2;
        private Button edzesre_Jelentkezes_Button;
    }
}