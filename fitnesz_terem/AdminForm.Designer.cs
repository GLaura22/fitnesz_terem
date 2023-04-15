namespace fitnesz_terem
{
    partial class AdminForm
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
            this.Users_with_data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filter_Text_Box = new System.Windows.Forms.TextBox();
            this.Items_with_data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Filter_text_Box_Items = new System.Windows.Forms.TextBox();
            this.keresoPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.keresésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosultságokKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edzésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oktatóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisztikákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visszajelzésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).BeginInit();
            this.keresoPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users_with_data
            // 
            this.Users_with_data.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.Users_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_with_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Users_with_data.Location = new System.Drawing.Point(3, 128);
            this.Users_with_data.Name = "Users_with_data";
            this.Users_with_data.RowTemplate.Height = 25;
            this.Users_with_data.Size = new System.Drawing.Size(474, 232);
            this.Users_with_data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználók\r\n";
            // 
            // filter_Text_Box
            // 
            this.filter_Text_Box.Location = new System.Drawing.Point(170, 53);
            this.filter_Text_Box.Name = "filter_Text_Box";
            this.filter_Text_Box.Size = new System.Drawing.Size(172, 23);
            this.filter_Text_Box.TabIndex = 3;
            this.filter_Text_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Items_with_data
            // 
            this.Items_with_data.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.Items_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_with_data.Location = new System.Drawing.Point(506, 128);
            this.Items_with_data.Name = "Items_with_data";
            this.Items_with_data.RowTemplate.Height = 25;
            this.Items_with_data.Size = new System.Drawing.Size(457, 232);
            this.Items_with_data.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 74);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADMIN FELÜLET\r\nMinden adat élesben módosul\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szűrés név alapján:";
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(170, 90);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(172, 23);
            this.roleBox.TabIndex = 7;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jogosultság alapján:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RosyBrown;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(674, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Termékek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(506, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Szűrés név alapján:";
            // 
            // Filter_text_Box_Items
            // 
            this.Filter_text_Box_Items.Location = new System.Drawing.Point(660, 90);
            this.Filter_text_Box_Items.Name = "Filter_text_Box_Items";
            this.Filter_text_Box_Items.Size = new System.Drawing.Size(173, 23);
            this.Filter_text_Box_Items.TabIndex = 11;
            // 
            // keresoPanel
            // 
            this.keresoPanel.Controls.Add(this.Filter_text_Box_Items);
            this.keresoPanel.Controls.Add(this.label6);
            this.keresoPanel.Controls.Add(this.label5);
            this.keresoPanel.Controls.Add(this.label4);
            this.keresoPanel.Controls.Add(this.roleBox);
            this.keresoPanel.Controls.Add(this.label3);
            this.keresoPanel.Controls.Add(this.Items_with_data);
            this.keresoPanel.Controls.Add(this.filter_Text_Box);
            this.keresoPanel.Controls.Add(this.label1);
            this.keresoPanel.Controls.Add(this.Users_with_data);
            this.keresoPanel.Location = new System.Drawing.Point(9, 99);
            this.keresoPanel.Name = "keresoPanel";
            this.keresoPanel.Size = new System.Drawing.Size(969, 375);
            this.keresoPanel.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keresésToolStripMenuItem,
            this.jogosultságokKezeléseToolStripMenuItem,
            this.hozzáadásToolStripMenuItem,
            this.statisztikákToolStripMenuItem,
            this.visszajelzésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 637);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            this.keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            this.keresésToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.keresésToolStripMenuItem.Text = "keresés";
            // 
            // jogosultságokKezeléseToolStripMenuItem
            // 
            this.jogosultságokKezeléseToolStripMenuItem.Name = "jogosultságokKezeléseToolStripMenuItem";
            this.jogosultságokKezeléseToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.jogosultságokKezeléseToolStripMenuItem.Text = "jogosultságok kezelése";
            // 
            // hozzáadásToolStripMenuItem
            // 
            this.hozzáadásToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edzésToolStripMenuItem,
            this.termékToolStripMenuItem,
            this.oktatóToolStripMenuItem});
            this.hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            this.hozzáadásToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hozzáadásToolStripMenuItem.Text = "hozzáadás";
            // 
            // edzésToolStripMenuItem
            // 
            this.edzésToolStripMenuItem.Name = "edzésToolStripMenuItem";
            this.edzésToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.edzésToolStripMenuItem.Text = "edzés";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.termékToolStripMenuItem.Text = "termék";
            // 
            // oktatóToolStripMenuItem
            // 
            this.oktatóToolStripMenuItem.Name = "oktatóToolStripMenuItem";
            this.oktatóToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.oktatóToolStripMenuItem.Text = "oktató";
            // 
            // statisztikákToolStripMenuItem
            // 
            this.statisztikákToolStripMenuItem.Name = "statisztikákToolStripMenuItem";
            this.statisztikákToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.statisztikákToolStripMenuItem.Text = "statisztikák";
            // 
            // visszajelzésekToolStripMenuItem
            // 
            this.visszajelzésekToolStripMenuItem.Name = "visszajelzésekToolStripMenuItem";
            this.visszajelzésekToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.visszajelzésekToolStripMenuItem.Text = "visszajelzések";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.keresoPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdmiNForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).EndInit();
            this.keresoPanel.ResumeLayout(false);
            this.keresoPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView Users_with_data;
        private Label label1;
        private TextBox filter_Text_Box;
        private DataGridView Items_with_data;
        private Label label2;
        private Label label3;
        private ComboBox roleBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Filter_text_Box_Items;
        private Panel keresoPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem keresésToolStripMenuItem;
        private ToolStripMenuItem jogosultságokKezeléseToolStripMenuItem;
        private ToolStripMenuItem hozzáadásToolStripMenuItem;
        private ToolStripMenuItem edzésToolStripMenuItem;
        private ToolStripMenuItem termékToolStripMenuItem;
        private ToolStripMenuItem oktatóToolStripMenuItem;
        private ToolStripMenuItem statisztikákToolStripMenuItem;
        private ToolStripMenuItem visszajelzésekToolStripMenuItem;
    }
}