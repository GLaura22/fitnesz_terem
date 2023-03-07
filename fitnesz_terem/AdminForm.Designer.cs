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
            comboBox1 = new ComboBox();
            Users_with_data = new DataGridView();
            label1 = new Label();
            filter_Text_Box = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Users_with_data).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(667, 415);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Users_with_data
            // 
            Users_with_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Users_with_data.Location = new Point(13, 69);
            Users_with_data.Name = "Users_with_data";
            Users_with_data.RowTemplate.Height = 25;
            Users_with_data.Size = new Size(293, 145);
            Users_with_data.TabIndex = 1;
            Users_with_data.CellEndEdit += Users_with_data_CellEndEdit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 2;
            label1.Text = "Felhasználók (Cellába adatmódosítás élesben történik)";
            // 
            // filter_Text_Box
            // 
            filter_Text_Box.Location = new Point(12, 40);
            filter_Text_Box.Name = "filter_Text_Box";
            filter_Text_Box.Size = new Size(294, 23);
            filter_Text_Box.TabIndex = 3;
            filter_Text_Box.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(548, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 4;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(filter_Text_Box);
            Controls.Add(label1);
            Controls.Add(Users_with_data);
            Controls.Add(comboBox1);
            Name = "AdminForm";
            Text = "AdmiNForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)Users_with_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView Users_with_data;
        private Label label1;
        private TextBox filter_Text_Box;
        private Panel panel1;
    }
}