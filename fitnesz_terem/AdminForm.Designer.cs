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
            Users_with_data = new DataGridView();
            label1 = new Label();
            filter_Text_Box = new TextBox();
            Items_with_data = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            roleBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Filter_text_Box_Items = new TextBox();
            keresoPanel = new Panel();
            menuStrip1 = new MenuStrip();
            keresésToolStripMenuItem = new ToolStripMenuItem();
            jogosultságokKezeléseToolStripMenuItem = new ToolStripMenuItem();
            hozzáadásToolStripMenuItem = new ToolStripMenuItem();
            visszajelzésekToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Users_with_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Items_with_data).BeginInit();
            keresoPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Users_with_data
            // 
            Users_with_data.BackgroundColor = Color.RosyBrown;
            Users_with_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_with_data.GridColor = SystemColors.ActiveCaptionText;
            Users_with_data.Location = new Point(3, 128);
            Users_with_data.Name = "Users_with_data";
            Users_with_data.RowTemplate.Height = 25;
            Users_with_data.Size = new Size(474, 232);
            Users_with_data.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(95, 10);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 2;
            label1.Text = "Felhasználók\r\n";
            // 
            // filter_Text_Box
            // 
            filter_Text_Box.Location = new Point(170, 53);
            filter_Text_Box.Name = "filter_Text_Box";
            filter_Text_Box.Size = new Size(172, 23);
            filter_Text_Box.TabIndex = 3;
            filter_Text_Box.TextChanged += textBox1_TextChanged;
            // 
            // Items_with_data
            // 
            Items_with_data.BackgroundColor = Color.RosyBrown;
            Items_with_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items_with_data.Location = new Point(506, 128);
            Items_with_data.Name = "Items_with_data";
            Items_with_data.RowTemplate.Height = 25;
            Items_with_data.Size = new Size(457, 232);
            Items_with_data.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(314, 9);
            label2.Name = "label2";
            label2.Size = new Size(377, 74);
            label2.TabIndex = 5;
            label2.Text = "ADMIN FELÜLET\r\nMinden adat élesben módosul\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 6;
            label3.Text = "Szűrés név alapján:";
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(170, 90);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(172, 23);
            roleBox.TabIndex = 7;
            roleBox.SelectedIndexChanged += roleBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 92);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 8;
            label4.Text = "Jogosultság alapján:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(674, 10);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 9;
            label5.Text = "Termékek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RosyBrown;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(506, 92);
            label6.Name = "label6";
            label6.Size = new Size(142, 21);
            label6.TabIndex = 10;
            label6.Text = "Szűrés név alapján:";
            // 
            // Filter_text_Box_Items
            // 
            Filter_text_Box_Items.Location = new Point(660, 90);
            Filter_text_Box_Items.Name = "Filter_text_Box_Items";
            Filter_text_Box_Items.Size = new Size(173, 23);
            Filter_text_Box_Items.TabIndex = 11;
            // 
            // keresoPanel
            // 
            keresoPanel.Controls.Add(Filter_text_Box_Items);
            keresoPanel.Controls.Add(label6);
            keresoPanel.Controls.Add(label5);
            keresoPanel.Controls.Add(label4);
            keresoPanel.Controls.Add(roleBox);
            keresoPanel.Controls.Add(label3);
            keresoPanel.Controls.Add(Items_with_data);
            keresoPanel.Controls.Add(filter_Text_Box);
            keresoPanel.Controls.Add(label1);
            keresoPanel.Controls.Add(Users_with_data);
            keresoPanel.Location = new Point(12, 130);
            keresoPanel.Name = "keresoPanel";
            keresoPanel.Size = new Size(969, 375);
            keresoPanel.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Bottom;
            menuStrip1.Items.AddRange(new ToolStripItem[] { keresésToolStripMenuItem, jogosultságokKezeléseToolStripMenuItem, hozzáadásToolStripMenuItem, visszajelzésekToolStripMenuItem });
            menuStrip1.Location = new Point(0, 637);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // keresésToolStripMenuItem
            // 
            keresésToolStripMenuItem.Name = "keresésToolStripMenuItem";
            keresésToolStripMenuItem.Size = new Size(57, 20);
            keresésToolStripMenuItem.Text = "keresés";
            // 
            // jogosultságokKezeléseToolStripMenuItem
            // 
            jogosultságokKezeléseToolStripMenuItem.Name = "jogosultságokKezeléseToolStripMenuItem";
            jogosultságokKezeléseToolStripMenuItem.Size = new Size(139, 20);
            jogosultságokKezeléseToolStripMenuItem.Text = "jogosultságok kezelése";
            jogosultságokKezeléseToolStripMenuItem.Click += jogosultságokKezeléseToolStripMenuItem_Click;
            // 
            // hozzáadásToolStripMenuItem
            // 
            hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            hozzáadásToolStripMenuItem.Size = new Size(73, 20);
            hozzáadásToolStripMenuItem.Text = "hozzáadás";
            hozzáadásToolStripMenuItem.Click += hozzáadásToolStripMenuItem_Click;
            // 
            // visszajelzésekToolStripMenuItem
            // 
            visszajelzésekToolStripMenuItem.Name = "visszajelzésekToolStripMenuItem";
            visszajelzésekToolStripMenuItem.Size = new Size(89, 20);
            visszajelzésekToolStripMenuItem.Text = "visszajelzések";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(984, 661);
            Controls.Add(keresoPanel);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            Text = "Adminisztrátor";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)Users_with_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)Items_with_data).EndInit();
            keresoPanel.ResumeLayout(false);
            keresoPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripMenuItem visszajelzésekToolStripMenuItem;
    }
}