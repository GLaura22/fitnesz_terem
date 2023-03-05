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
            cim = new Label();
            bejiregi = new Label();
            fokep = new PictureBox();
            fomenu = new MenuStrip();
            formenu1 = new ToolStripMenuItem();
            foszmenu2 = new ToolStripMenuItem();
            foemenu3 = new ToolStripMenuItem();
            fowmenu4 = new ToolStripMenuItem();
            textBoxRolunk = new TextBox();
            fogado_szoveg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fokep).BeginInit();
            fomenu.SuspendLayout();
            SuspendLayout();
            // 
            // cim
            // 
            cim.AutoSize = true;
            cim.BackColor = Color.Transparent;
            cim.Dock = DockStyle.Left;
            cim.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            cim.ForeColor = Color.White;
            cim.Location = new Point(0, 24);
            cim.Margin = new Padding(2, 0, 2, 0);
            cim.Name = "cim";
            cim.Size = new Size(344, 45);
            cim.TabIndex = 0;
            cim.Text = "Balaton Fitnesz terem";
            cim.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bejiregi
            // 
            bejiregi.Dock = DockStyle.Top;
            bejiregi.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point);
            bejiregi.ForeColor = SystemColors.ButtonHighlight;
            bejiregi.ImageAlign = ContentAlignment.MiddleRight;
            bejiregi.Location = new Point(344, 24);
            bejiregi.Margin = new Padding(2, 0, 2, 0);
            bejiregi.Name = "bejiregi";
            bejiregi.RightToLeft = RightToLeft.Yes;
            bejiregi.Size = new Size(288, 20);
            bejiregi.TabIndex = 1;
            bejiregi.Text = "Bejelentkezés/Regisztráció";
            bejiregi.Click += bejiregi_Click;
            // 
            // fokep
            // 
            fokep.Image = Properties.Resources.gym_hatter;
            fokep.Location = new Point(172, 80);
            fokep.Margin = new Padding(2);
            fokep.Name = "fokep";
            fokep.Size = new Size(265, 112);
            fokep.SizeMode = PictureBoxSizeMode.CenterImage;
            fokep.TabIndex = 2;
            fokep.TabStop = false;
            // 
            // fomenu
            // 
            fomenu.BackColor = Color.White;
            fomenu.ImageScalingSize = new Size(24, 24);
            fomenu.Items.AddRange(new ToolStripItem[] { formenu1, foszmenu2, foemenu3, fowmenu4 });
            fomenu.Location = new Point(0, 0);
            fomenu.Name = "fomenu";
            fomenu.Padding = new Padding(4, 1, 0, 1);
            fomenu.Size = new Size(632, 24);
            fomenu.TabIndex = 3;
            fomenu.Text = "menuStrip1";
            // 
            // formenu1
            // 
            formenu1.ForeColor = Color.Black;
            formenu1.Name = "formenu1";
            formenu1.Size = new Size(56, 22);
            formenu1.Text = "Rólunk";
            formenu1.Click += formenu1_Click;
            // 
            // foszmenu2
            // 
            foszmenu2.Name = "foszmenu2";
            foszmenu2.Size = new Size(103, 22);
            foszmenu2.Text = "Szolgáltatásaink";
            foszmenu2.Click += foszmenu2_Click;
            // 
            // foemenu3
            // 
            foemenu3.Name = "foemenu3";
            foemenu3.Size = new Size(60, 22);
            foemenu3.Text = "Edzőink";
            // 
            // fowmenu4
            // 
            fowmenu4.Name = "fowmenu4";
            fowmenu4.Size = new Size(110, 22);
            fowmenu4.Text = " Webshop kínálat";
            // 
            // textBoxRolunk
            // 
            textBoxRolunk.BackColor = Color.Black;
            textBoxRolunk.ForeColor = Color.White;
            textBoxRolunk.Location = new Point(63, 261);
            textBoxRolunk.Margin = new Padding(2);
            textBoxRolunk.Name = "textBoxRolunk";
            textBoxRolunk.Size = new Size(474, 23);
            textBoxRolunk.TabIndex = 4;
            textBoxRolunk.Text = "Ez egy nagyon cuki gym gyere ide kigyúrod magad szép leszel\r\n";
            textBoxRolunk.TextAlign = HorizontalAlignment.Center;
            // 
            // fogado_szoveg
            // 
            fogado_szoveg.BackColor = Color.Black;
            fogado_szoveg.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            fogado_szoveg.ForeColor = Color.White;
            fogado_szoveg.Location = new Point(57, 227);
            fogado_szoveg.Margin = new Padding(2);
            fogado_szoveg.Name = "fogado_szoveg";
            fogado_szoveg.Size = new Size(488, 36);
            fogado_szoveg.TabIndex = 5;
            fogado_szoveg.Text = "Üdvözlünk a Balaton Fitness terem honlapján!";
            fogado_szoveg.TextAlign = HorizontalAlignment.Center;
            // 
            // indulo_felulet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(632, 329);
            Controls.Add(fogado_szoveg);
            Controls.Add(textBoxRolunk);
            Controls.Add(fokep);
            Controls.Add(bejiregi);
            Controls.Add(cim);
            Controls.Add(fomenu);
            MainMenuStrip = fomenu;
            Margin = new Padding(2);
            Name = "indulo_felulet";
            Text = "Kezdőoldal";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            Load += indulo_felulet_Load;
            Resize += indulo_felulet_Resize;
            ((System.ComponentModel.ISupportInitialize)fokep).EndInit();
            fomenu.ResumeLayout(false);
            fomenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox fogado_szoveg;
    }
}