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
            SuspendLayout();
            // 
            // felhlabel
            // 
            felhlabel.AutoSize = true;
            felhlabel.Location = new Point(141, 103);
            felhlabel.Margin = new Padding(2, 0, 2, 0);
            felhlabel.Name = "felhlabel";
            felhlabel.Size = new Size(90, 15);
            felhlabel.TabIndex = 0;
            felhlabel.Text = "Felhasználónév:";
            // 
            // jelszolabel
            // 
            jelszolabel.AutoSize = true;
            jelszolabel.Location = new Point(141, 155);
            jelszolabel.Margin = new Padding(2, 0, 2, 0);
            jelszolabel.Name = "jelszolabel";
            jelszolabel.Size = new Size(40, 15);
            jelszolabel.TabIndex = 1;
            jelszolabel.Text = "Jelszó:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 130);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 184);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
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
            regilabel.Location = new Point(300, 223);
            regilabel.Margin = new Padding(2, 0, 2, 0);
            regilabel.Name = "regilabel";
            regilabel.Size = new Size(70, 15);
            regilabel.TabIndex = 5;
            regilabel.Text = "Regisztráció";
            // 
            // Belepes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(531, 307);
            Controls.Add(regilabel);
            Controls.Add(cim);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(jelszolabel);
            Controls.Add(felhlabel);
            ForeColor = Color.White;
            Margin = new Padding(2);
            MinimumSize = new Size(420, 289);
            Name = "Belepes";
            Text = "Bejelentkezés";
            Load += Belepes_Load;
            Resize += Belepes_Resize;
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
    }
}