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
            this.groupBoxbelep = new System.Windows.Forms.GroupBox();
            this.belepButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxbelep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // felhlabel
            // 
            this.felhlabel.AutoSize = true;
            this.felhlabel.Location = new System.Drawing.Point(20, 22);
            this.felhlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.felhlabel.Name = "felhlabel";
            this.felhlabel.Size = new System.Drawing.Size(104, 19);
            this.felhlabel.TabIndex = 0;
            this.felhlabel.Text = "Felhasználónév:";
            // 
            // jelszolabel
            // 
            this.jelszolabel.AutoSize = true;
            this.jelszolabel.Location = new System.Drawing.Point(20, 77);
            this.jelszolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jelszolabel.Name = "jelszolabel";
            this.jelszolabel.Size = new System.Drawing.Size(47, 19);
            this.jelszolabel.TabIndex = 1;
            this.jelszolabel.Text = "Jelszó:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 103);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 25);
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
            this.cim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(344, 45);
            this.cim.TabIndex = 4;
            this.cim.Text = "Balaton Fitnesz terem";
            this.cim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // regilabel
            // 
            this.regilabel.AutoSize = true;
            this.regilabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.regilabel.Location = new System.Drawing.Point(96, 142);
            this.regilabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regilabel.Name = "regilabel";
            this.regilabel.Size = new System.Drawing.Size(70, 15);
            this.regilabel.TabIndex = 5;
            this.regilabel.Text = "Regisztráció";
            this.regilabel.Click += new System.EventHandler(this.regilabel_Click);
            // 
            // groupBoxbelep
            // 
            this.groupBoxbelep.BackColor = System.Drawing.Color.Black;
            this.groupBoxbelep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxbelep.Controls.Add(this.belepButton);
            this.groupBoxbelep.Controls.Add(this.pictureBox1);
            this.groupBoxbelep.Controls.Add(this.regilabel);
            this.groupBoxbelep.Controls.Add(this.textBox2);
            this.groupBoxbelep.Controls.Add(this.textBox1);
            this.groupBoxbelep.Controls.Add(this.jelszolabel);
            this.groupBoxbelep.Controls.Add(this.felhlabel);
            this.groupBoxbelep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxbelep.ForeColor = System.Drawing.Color.Transparent;
            this.groupBoxbelep.Location = new System.Drawing.Point(253, 152);
            this.groupBoxbelep.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxbelep.Name = "groupBoxbelep";
            this.groupBoxbelep.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxbelep.Size = new System.Drawing.Size(281, 184);
            this.groupBoxbelep.TabIndex = 6;
            this.groupBoxbelep.TabStop = false;
            this.groupBoxbelep.Text = "Belépés";
            // 
            // belepButton
            // 
            this.belepButton.ForeColor = System.Drawing.Color.Black;
            this.belepButton.Location = new System.Drawing.Point(193, 139);
            this.belepButton.Margin = new System.Windows.Forms.Padding(2);
            this.belepButton.Name = "belepButton";
            this.belepButton.Size = new System.Drawing.Size(72, 27);
            this.belepButton.TabIndex = 8;
            this.belepButton.Text = "Belépés";
            this.belepButton.UseVisualStyleBackColor = true;
            this.belepButton.Click += new System.EventHandler(this.belepButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fitnesz_terem.Properties.Resources.sulyzo;
            this.pictureBox1.Location = new System.Drawing.Point(4, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Belepes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::fitnesz_terem.Properties.Resources.sotetbgr;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBoxbelep);
            this.Controls.Add(this.cim);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Belepes";
            this.Text = "Bejelentkezés";
            this.groupBoxbelep.ResumeLayout(false);
            this.groupBoxbelep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private GroupBox groupBoxbelep;
        private PictureBox pictureBox1;
        private Button belepButton;
    }
}