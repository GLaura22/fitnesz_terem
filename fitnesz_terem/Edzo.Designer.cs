namespace fitnesz_terem
{
    partial class Edzo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(465, 110);
            button1.Name = "button1";
            button1.Size = new Size(133, 27);
            button1.TabIndex = 0;
            button1.Text = "Óra hozzáadása";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 189);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Keresés";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 3;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(228, 114);
            button2.Name = "button2";
            button2.Size = new Size(57, 23);
            button2.TabIndex = 4;
            button2.Text = "keresés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kliensek név szerint", "Órák" });
            comboBox1.Location = new Point(77, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ActiveCaptionText;
            monthCalendar1.ForeColor = Color.Black;
            monthCalendar1.Location = new Point(604, 270);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.TitleBackColor = SystemColors.ControlDarkDark;
            monthCalendar1.TitleForeColor = SystemColors.AppWorkspace;
            monthCalendar1.TrailingForeColor = SystemColors.Highlight;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(77, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 7;
            dataGridView1.Visible = false;
            // 
            // Edzo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "Edzo";
            Text = " ";
            Load += Edzo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
    }
}