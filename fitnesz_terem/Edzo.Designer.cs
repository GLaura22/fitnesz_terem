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
            button2 = new Button();
            comboBox1 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(189, 1);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 0;
            button1.Text = "Óra hozzáadása";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 395);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 2;
            label2.Text = "Keresés:";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(6, 1);
            button2.Name = "button2";
            button2.Size = new Size(112, 32);
            button2.TabIndex = 4;
            button2.Text = "keresés";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kurzusok", "Személyi edzések" });
            comboBox1.Location = new Point(63, 430);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.ActiveCaptionText;
            monthCalendar1.ForeColor = Color.Black;
            monthCalendar1.Location = new Point(767, 465);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.TitleBackColor = SystemColors.ControlDarkDark;
            monthCalendar1.TitleForeColor = SystemColors.AppWorkspace;
            monthCalendar1.TrailingForeColor = SystemColors.Highlight;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.Window;
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
            dataGridView1.Location = new Point(63, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(675, 162);
            dataGridView1.TabIndex = 7;
            dataGridView1.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(414, 0);
            button3.Name = "button3";
            button3.Size = new Size(143, 33);
            button3.TabIndex = 8;
            button3.Text = "Kurzus törlés";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(422, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 23);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(919, 51);
            label1.TabIndex = 10;
            label1.Text = "Hello";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(247, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 11;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(246, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 12;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 120);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 13;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(246, 154);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(122, 23);
            textBox6.TabIndex = 14;
            textBox6.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(162, 54);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 15;
            label3.Text = "Kezdés:";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(146, 86);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 16;
            label4.Text = "Befejezés:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(124, 122);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 17;
            label5.Text = "Max létszám:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(151, 152);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 18;
            label6.Text = "Location:";
            label6.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(245, 186);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 23);
            textBox7.TabIndex = 19;
            textBox7.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(134, 188);
            label7.Name = "label7";
            label7.Size = new Size(89, 21);
            label7.TabIndex = 20;
            label7.Text = "Kurzus név:";
            label7.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(222, 258);
            button4.Name = "button4";
            button4.Size = new Size(83, 37);
            button4.TabIndex = 21;
            button4.Text = "Felvisz";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(468, 200);
            button5.Name = "button5";
            button5.Size = new Size(87, 32);
            button5.TabIndex = 22;
            button5.Text = "Törlés";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(466, 83);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 23;
            label8.Text = "Kurzus név:";
            label8.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(371, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 312);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // Edzo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(984, 661);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Edzo";
            Text = " ";
            Load += Edzo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Button button2;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button4;
        private Button button5;
        private Label label8;
        private GroupBox groupBox1;
    }
}