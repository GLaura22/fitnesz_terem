namespace fitnesz_terem
{
    partial class Belepes
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
            felhlabel = new Label();
            jelszolabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            cim = new Label();
            regilabel = new Label();
            groupBoxbelep = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxbelep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // felhlabel
            // 
            felhlabel.AutoSize = true;
            felhlabel.Location = new Point(20, 22);
            felhlabel.Margin = new Padding(2, 0, 2, 0);
            felhlabel.Name = "felhlabel";
            felhlabel.Size = new Size(104, 19);
            felhlabel.TabIndex = 0;
            felhlabel.Text = "Felhasználónév:";
            // 
            // jelszolabel
            // 
            jelszolabel.AutoSize = true;
            jelszolabel.Location = new Point(20, 77);
            jelszolabel.Margin = new Padding(2, 0, 2, 0);
            jelszolabel.Name = "jelszolabel";
            jelszolabel.Size = new Size(47, 19);
            jelszolabel.TabIndex = 1;
            jelszolabel.Text = "Jelszó:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 48);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 25);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 103);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 25);
            textBox2.TabIndex = 3;
            // 
            // cim
            // 
            cim.AutoSize = true;
            cim.BackColor = Color.Transparent;
            cim.Dock = DockStyle.Left;
            cim.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            cim.ForeColor = Color.White;
            cim.Location = new Point(0, 0);
            cim.Margin = new Padding(2, 0, 2, 0);
            cim.Name = "cim";
            cim.Size = new Size(344, 45);
            cim.TabIndex = 4;
            cim.Text = "Balaton Fitnesz terem";
            cim.TextAlign = ContentAlignment.MiddleRight;
            // 
            // regilabel
            // 
            regilabel.AutoSize = true;
            regilabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            regilabel.Location = new Point(179, 141);
            regilabel.Margin = new Padding(2, 0, 2, 0);
            regilabel.Name = "regilabel";
            regilabel.Size = new Size(70, 15);
            regilabel.TabIndex = 5;
            regilabel.Text = "Regisztráció";
            regilabel.Click += regilabel_Click;
            // 
            // groupBoxbelep
            // 
            groupBoxbelep.BackColor = Color.Black;
            groupBoxbelep.BackgroundImageLayout = ImageLayout.Center;
            groupBoxbelep.Controls.Add(pictureBox1);
            groupBoxbelep.Controls.Add(regilabel);
            groupBoxbelep.Controls.Add(textBox2);
            groupBoxbelep.Controls.Add(textBox1);
            groupBoxbelep.Controls.Add(jelszolabel);
            groupBoxbelep.Controls.Add(felhlabel);
            groupBoxbelep.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxbelep.ForeColor = Color.Transparent;
            groupBoxbelep.Location = new Point(134, 73);
            groupBoxbelep.Margin = new Padding(2);
            groupBoxbelep.Name = "groupBoxbelep";
            groupBoxbelep.Padding = new Padding(2);
            groupBoxbelep.Size = new Size(281, 184);
            groupBoxbelep.TabIndex = 6;
            groupBoxbelep.TabStop = false;
            groupBoxbelep.Text = "Belépés";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sulyzo;
            pictureBox1.Location = new Point(4, -4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Belepes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 320);
            Controls.Add(groupBoxbelep);
            Controls.Add(cim);
            ForeColor = Color.White;
            Margin = new Padding(2);
            Name = "Belepes";
            Text = "Bejelentkezés";
            Load += Belepes_Load;
            Resize += Belepes_Resize;
            groupBoxbelep.ResumeLayout(false);
            groupBoxbelep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label felhlabel;
        private Label jelszolabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label cim;
        private Label regilabel;
        private GroupBox groupBoxbelep;
        private PictureBox pictureBox1;
    }
}