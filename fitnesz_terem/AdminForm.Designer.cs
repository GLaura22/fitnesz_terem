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
            ((System.ComponentModel.ISupportInitialize)Users_with_data).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Items_with_data).BeginInit();
            SuspendLayout();
            // 
            // Users_with_data
            // 
            Users_with_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_with_data.Location = new Point(12, 138);
            Users_with_data.Name = "Users_with_data";
            Users_with_data.RowTemplate.Height = 25;
            Users_with_data.Size = new Size(474, 232);
            Users_with_data.TabIndex = 1;
            Users_with_data.CellEndEdit += Users_with_data_CellEndEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Menu;
            label1.Location = new Point(201, 71);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Felhasználók\r\n";
            // 
            // filter_Text_Box
            // 
            filter_Text_Box.Location = new Point(123, 105);
            filter_Text_Box.Name = "filter_Text_Box";
            filter_Text_Box.Size = new Size(98, 23);
            filter_Text_Box.TabIndex = 3;
            filter_Text_Box.TextChanged += textBox1_TextChanged;
            // 
            // Items_with_data
            // 
            Items_with_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items_with_data.Location = new Point(515, 138);
            Items_with_data.Name = "Items_with_data";
            Items_with_data.RowTemplate.Height = 25;
            Items_with_data.Size = new Size(457, 232);
            Items_with_data.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(372, 9);
            label2.Name = "label2";
            label2.Size = new Size(267, 50);
            label2.TabIndex = 5;
            label2.Text = "ADMIN FELÜLET\r\nMinden adat élesben módosul\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(105, 13);
            label3.TabIndex = 6;
            label3.Text = "Szűrés név alapján:";
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(330, 105);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(102, 23);
            roleBox.TabIndex = 7;
            roleBox.SelectedIndexChanged += roleBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(242, 109);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Jogosultság:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(984, 640);
            Controls.Add(label4);
            Controls.Add(roleBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Items_with_data);
            Controls.Add(filter_Text_Box);
            Controls.Add(label1);
            Controls.Add(Users_with_data);
            Name = "AdminForm";
            Text = "AdmiNForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)Users_with_data).EndInit();
            ((System.ComponentModel.ISupportInitialize)Items_with_data).EndInit();
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
    }
}