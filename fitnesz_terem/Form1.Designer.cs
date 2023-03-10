namespace fitnesz_terem
{
    partial class indulo_felulet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public static System.Drawing.Color Transparent { get; }

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(indulo_felulet));
            this.cim = new System.Windows.Forms.Label();
            this.bejiregi = new System.Windows.Forms.Label();
            this.fokep = new System.Windows.Forms.PictureBox();
            this.fomenu = new System.Windows.Forms.MenuStrip();
            this.formenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.foszmenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.foemenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fowmenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxRolunk = new System.Windows.Forms.TextBox();
            this.adminLabel = new System.Windows.Forms.Label();
            this.fogado_szoveg = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.szolgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fokep)).BeginInit();
            this.fomenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.BackColor = System.Drawing.Color.Transparent;
            this.cim.Dock = System.Windows.Forms.DockStyle.Left;
            this.cim.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cim.ForeColor = System.Drawing.Color.Black;
            this.cim.Location = new System.Drawing.Point(0, 24);
            this.cim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(344, 45);
            this.cim.TabIndex = 0;
            this.cim.Text = "Balaton Fitnesz terem";
            this.cim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bejiregi
            // 
            this.bejiregi.Dock = System.Windows.Forms.DockStyle.Top;
            this.bejiregi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.bejiregi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bejiregi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bejiregi.Location = new System.Drawing.Point(344, 24);
            this.bejiregi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bejiregi.Name = "bejiregi";
            this.bejiregi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bejiregi.Size = new System.Drawing.Size(319, 20);
            this.bejiregi.TabIndex = 1;
            this.bejiregi.Text = "Bejelentkezés/Regisztráció";
            this.bejiregi.Click += new System.EventHandler(this.bejiregi_Click);
            // 
            // fokep
            // 
            this.fokep.Image = global::fitnesz_terem.Properties.Resources.gym_hatter;
            this.fokep.Location = new System.Drawing.Point(184, 91);
            this.fokep.Margin = new System.Windows.Forms.Padding(2);
            this.fokep.Name = "fokep";
            this.fokep.Size = new System.Drawing.Size(278, 132);
            this.fokep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fokep.TabIndex = 2;
            this.fokep.TabStop = false;
            // 
            // fomenu
            // 
            this.fomenu.BackColor = System.Drawing.Color.White;
            this.fomenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fomenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formenu1,
            this.foszmenu2,
            this.foemenu3,
            this.fowmenu4});
            this.fomenu.Location = new System.Drawing.Point(0, 0);
            this.fomenu.Name = "fomenu";
            this.fomenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.fomenu.Size = new System.Drawing.Size(663, 24);
            this.fomenu.TabIndex = 3;
            this.fomenu.Text = "menuStrip1";
            // 
            // formenu1
            // 
            this.formenu1.ForeColor = System.Drawing.Color.Black;
            this.formenu1.Name = "formenu1";
            this.formenu1.Size = new System.Drawing.Size(56, 22);
            this.formenu1.Text = "Rólunk";
            this.formenu1.Click += new System.EventHandler(this.formenu1_Click);
            // 
            // foszmenu2
            // 
            this.foszmenu2.Name = "foszmenu2";
            this.foszmenu2.Size = new System.Drawing.Size(103, 22);
            this.foszmenu2.Text = "Szolgáltatásaink";
            this.foszmenu2.Click += new System.EventHandler(this.foszmenu2_Click);
            // 
            // foemenu3
            // 
            this.foemenu3.Name = "foemenu3";
            this.foemenu3.Size = new System.Drawing.Size(60, 22);
            this.foemenu3.Text = "Edzőink";
            // 
            // fowmenu4
            // 
            this.fowmenu4.Name = "fowmenu4";
            this.fowmenu4.Size = new System.Drawing.Size(110, 22);
            this.fowmenu4.Text = " Webshop kínálat";
            // 
            // textBoxRolunk
            // 
            this.textBoxRolunk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(198)))), ((int)(((byte)(249)))));
            this.textBoxRolunk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRolunk.ForeColor = System.Drawing.Color.Black;
            this.textBoxRolunk.Location = new System.Drawing.Point(63, 248);
            this.textBoxRolunk.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRolunk.Multiline = true;
            this.textBoxRolunk.Name = "textBoxRolunk";
            this.textBoxRolunk.Size = new System.Drawing.Size(515, 69);
            this.textBoxRolunk.TabIndex = 4;
            this.textBoxRolunk.Text = resources.GetString("textBoxRolunk.Text");
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(198)))), ((int)(((byte)(249)))));
            this.adminLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adminLabel.Location = new System.Drawing.Point(572, 315);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(69, 15);
            this.adminLabel.TabIndex = 6;
            this.adminLabel.Text = "AdminPage";
            this.adminLabel.Click += new System.EventHandler(this.adminLabel_Click);
            // 
            // fogado_szoveg
            // 
            this.fogado_szoveg.AutoSize = true;
            this.fogado_szoveg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fogado_szoveg.Location = new System.Drawing.Point(43, 264);
            this.fogado_szoveg.Name = "fogado_szoveg";
            this.fogado_szoveg.Size = new System.Drawing.Size(535, 32);
            this.fogado_szoveg.TabIndex = 7;
            this.fogado_szoveg.Text = "Üdvözlünk a Balaton fitness terem honlapján!";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 275);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // szolgLabel
            // 
            this.szolgLabel.AutoSize = true;
            this.szolgLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.szolgLabel.Location = new System.Drawing.Point(110, 248);
            this.szolgLabel.Name = "szolgLabel";
            this.szolgLabel.Size = new System.Drawing.Size(207, 21);
            this.szolgLabel.TabIndex = 9;
            this.szolgLabel.Text = "Elérhető szolgáltatásaink:";
            // 
            // indulo_felulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(198)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(663, 348);
            this.Controls.Add(this.szolgLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fogado_szoveg);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.textBoxRolunk);
            this.Controls.Add(this.fokep);
            this.Controls.Add(this.bejiregi);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.fomenu);
            this.MainMenuStrip = this.fomenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "indulo_felulet";
            this.Text = "Kezdőoldal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.fokep)).EndInit();
            this.fomenu.ResumeLayout(false);
            this.fomenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cim;
        private Label bejiregi;
        private PictureBox fokep;
        private MenuStrip fomenu;
        private ToolStripMenuItem formenu1;
        private ToolStripMenuItem foszmenu2;
        private ToolStripMenuItem foemenu3;
        private ToolStripMenuItem fowmenu4;
        private TextBox textBoxRolunk;
        private Label adminLabel;
        private Label fogado_szoveg;
        private ComboBox comboBox1;
        private Label szolgLabel;
    }
}