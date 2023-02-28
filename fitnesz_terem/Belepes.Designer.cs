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
            this.felhlabel = new System.Windows.Forms.Label();
            this.jelszolabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cim = new System.Windows.Forms.Label();
            this.regilabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // felhlabel
            // 
            this.felhlabel.AutoSize = true;
            this.felhlabel.Location = new System.Drawing.Point(201, 172);
            this.felhlabel.Name = "felhlabel";
            this.felhlabel.Size = new System.Drawing.Size(135, 25);
            this.felhlabel.TabIndex = 0;
            this.felhlabel.Text = "Felhasználónév:";
            // 
            // jelszolabel
            // 
            this.jelszolabel.AutoSize = true;
            this.jelszolabel.Location = new System.Drawing.Point(201, 259);
            this.jelszolabel.Name = "jelszolabel";
            this.jelszolabel.Size = new System.Drawing.Size(62, 25);
            this.jelszolabel.TabIndex = 1;
            this.jelszolabel.Text = "Jelszó:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 31);
            this.textBox2.TabIndex = 3;
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.BackColor = System.Drawing.Color.Transparent;
            this.cim.Dock = System.Windows.Forms.DockStyle.Left;
            this.cim.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cim.ForeColor = System.Drawing.Color.White;
            this.cim.Location = new System.Drawing.Point(0, 0);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(519, 65);
            this.cim.TabIndex = 4;
            this.cim.Text = "Balaton Fitnesz terem";
            this.cim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regilabel
            // 
            this.regilabel.AutoSize = true;
            this.regilabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.regilabel.Location = new System.Drawing.Point(428, 371);
            this.regilabel.Name = "regilabel";
            this.regilabel.Size = new System.Drawing.Size(106, 25);
            this.regilabel.TabIndex = 5;
            this.regilabel.Text = "Regisztráció";
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regilabel);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.jelszolabel);
            this.Controls.Add(this.felhlabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Belepes";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

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