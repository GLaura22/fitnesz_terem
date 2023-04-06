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
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_with_data
            // 
            this.Users_with_data.BackgroundColor = System.Drawing.Color.White;
            this.Users_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_with_data.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Users_with_data.Location = new System.Drawing.Point(12, 138);
            this.Users_with_data.Name = "Users_with_data";
            this.Users_with_data.RowTemplate.Height = 25;
            this.Users_with_data.Size = new System.Drawing.Size(474, 232);
            this.Users_with_data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(201, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználók\r\n";
            // 
            // filter_Text_Box
            // 
            this.filter_Text_Box.Location = new System.Drawing.Point(123, 105);
            this.filter_Text_Box.Name = "filter_Text_Box";
            this.filter_Text_Box.Size = new System.Drawing.Size(98, 23);
            this.filter_Text_Box.TabIndex = 3;
            this.filter_Text_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Items_with_data
            // 
            this.Items_with_data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Items_with_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items_with_data.Location = new System.Drawing.Point(515, 138);
            this.Items_with_data.Name = "Items_with_data";
            this.Items_with_data.RowTemplate.Height = 25;
            this.Items_with_data.Size = new System.Drawing.Size(457, 232);
            this.Items_with_data.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADMIN FELÜLET\r\nMinden adat élesben módosul\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szűrés név alapján:";
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(330, 105);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(102, 23);
            this.roleBox.TabIndex = 7;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(242, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jogosultság:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(713, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Termékek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(515, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Szűrés név szerint";
            // 
            // Filter_text_Box_Items
            // 
            this.Filter_text_Box_Items.Location = new System.Drawing.Point(620, 105);
            this.Filter_text_Box_Items.Name = "Filter_text_Box_Items";
            this.Filter_text_Box_Items.Size = new System.Drawing.Size(100, 23);
            this.Filter_text_Box_Items.TabIndex = 11;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(984, 676);
            this.Controls.Add(this.Filter_text_Box_Items);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Items_with_data);
            this.Controls.Add(this.filter_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users_with_data);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminForm";
            this.Text = "AdmiNForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_with_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Items_with_data)).EndInit();
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
    }
}