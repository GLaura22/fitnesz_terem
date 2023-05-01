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
            components = new System.ComponentModel.Container();
            cim = new Label();
            bejiregi = new Label();
            fokep = new PictureBox();
            fomenu = new MenuStrip();
            formenu1 = new ToolStripMenuItem();
            foszmenu2 = new ToolStripMenuItem();
            foemenu3 = new ToolStripMenuItem();
            fowmenu4 = new ToolStripMenuItem();
            fogado_szoveg = new Label();
            comboBox1 = new ComboBox();
            szolgLabel = new Label();
            textBoxRolunk = new TextBox();
            dataBindingSource1 = new BindingSource(components);
            fitnessDbContextBindingSource = new BindingSource(components);
            dataBindingSource = new BindingSource(components);
            tajekoztatoLabel = new Label();
            edzok_felsorolas = new ListBox();
            szemelyiEdzoaArLabel = new Label();
            csoportosEdzesArLabel = new Label();
            WebshopListView = new ListView();
            ProductName = new ColumnHeader();
            ProductPrice = new ColumnHeader();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fokep).BeginInit();
            fomenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fitnessDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource).BeginInit();
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
            bejiregi.BackColor = Color.Transparent;
            bejiregi.Dock = DockStyle.Top;
            bejiregi.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point);
            bejiregi.ForeColor = Color.White;
            bejiregi.ImageAlign = ContentAlignment.MiddleRight;
            bejiregi.Location = new Point(344, 24);
            bejiregi.Margin = new Padding(2, 0, 2, 0);
            bejiregi.Name = "bejiregi";
            bejiregi.RightToLeft = RightToLeft.Yes;
            bejiregi.Size = new Size(840, 20);
            bejiregi.TabIndex = 1;
            bejiregi.Text = "Bejelentkezés/Regisztráció";
            bejiregi.Click += bejiregi_Click;
            // 
            // fokep
            // 
            fokep.BackColor = Color.Transparent;
            fokep.Image = Properties.Resources.kickboxing;
            fokep.Location = new Point(344, 137);
            fokep.Margin = new Padding(2);
            fokep.Name = "fokep";
            fokep.Size = new Size(545, 296);
            fokep.SizeMode = PictureBoxSizeMode.Zoom;
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
            fomenu.Size = new Size(1184, 24);
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
            foemenu3.Click += foemenu3_Click;
            // 
            // fowmenu4
            // 
            fowmenu4.Name = "fowmenu4";
            fowmenu4.Size = new Size(110, 22);
            fowmenu4.Text = " Webshop kínálat";
            fowmenu4.Click += fowmenu4_Click;
            // 
            // fogado_szoveg
            // 
            fogado_szoveg.AutoSize = true;
            fogado_szoveg.BackColor = Color.Transparent;
            fogado_szoveg.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            fogado_szoveg.ForeColor = Color.White;
            fogado_szoveg.Location = new Point(315, 530);
            fogado_szoveg.Name = "fogado_szoveg";
            fogado_szoveg.Size = new Size(644, 40);
            fogado_szoveg.TabIndex = 7;
            fogado_szoveg.Text = "Üdvözlünk a Balaton fitness terem honlapján!";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Black;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(565, 504);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(217, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextUpdate += comboBox1_SelectedIndexChanged;
            // 
            // szolgLabel
            // 
            szolgLabel.AutoSize = true;
            szolgLabel.BackColor = Color.Transparent;
            szolgLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            szolgLabel.ForeColor = Color.White;
            szolgLabel.Location = new Point(195, 500);
            szolgLabel.Name = "szolgLabel";
            szolgLabel.Size = new Size(306, 32);
            szolgLabel.TabIndex = 9;
            szolgLabel.Text = "Elérhető szolgáltatásaink:";
            // 
            // textBoxRolunk
            // 
            textBoxRolunk.BackColor = Color.Black;
            textBoxRolunk.BorderStyle = BorderStyle.None;
            textBoxRolunk.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRolunk.ForeColor = Color.White;
            textBoxRolunk.Location = new Point(403, 542);
            textBoxRolunk.Multiline = true;
            textBoxRolunk.Name = "textBoxRolunk";
            textBoxRolunk.Size = new Size(462, 114);
            textBoxRolunk.TabIndex = 10;
            textBoxRolunk.Text = "Egy modern, jól felszerelt edzőtermet üzemeltetünk a Balaton partján mindenkinek, aki egyedül vagy csoportban szeretne sportolni.  Várunk szeretettel, ha neked is fontos az egészséges életmód. ";
            textBoxRolunk.TextAlign = HorizontalAlignment.Center;
            // 
            // dataBindingSource1
            // 
            dataBindingSource1.DataSource = typeof(Database_Backend.Modells_Tables.Data);
            // 
            // fitnessDbContextBindingSource
            // 
            fitnessDbContextBindingSource.DataSource = typeof(Database_Backend.Connection.FitnessDbContext);
            // 
            // dataBindingSource
            // 
            dataBindingSource.DataSource = typeof(Database_Backend.Modells_Tables.Data);
            // 
            // tajekoztatoLabel
            // 
            tajekoztatoLabel.AutoSize = true;
            tajekoztatoLabel.BackColor = Color.Transparent;
            tajekoztatoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tajekoztatoLabel.ForeColor = Color.White;
            tajekoztatoLabel.Location = new Point(371, 184);
            tajekoztatoLabel.Name = "tajekoztatoLabel";
            tajekoztatoLabel.Size = new Size(494, 32);
            tajekoztatoLabel.TabIndex = 12;
            tajekoztatoLabel.Text = "Minden edzőnk vállal személyes edzést is!";
            // 
            // edzok_felsorolas
            // 
            edzok_felsorolas.BackColor = SystemColors.MenuText;
            edzok_felsorolas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            edzok_felsorolas.ForeColor = Color.White;
            edzok_felsorolas.FormattingEnabled = true;
            edzok_felsorolas.ItemHeight = 25;
            edzok_felsorolas.Location = new Point(473, 287);
            edzok_felsorolas.Name = "edzok_felsorolas";
            edzok_felsorolas.Size = new Size(309, 179);
            edzok_felsorolas.TabIndex = 13;
            edzok_felsorolas.SelectedIndexChanged += edzok_felsorolas_SelectedIndexChanged;
            // 
            // szemelyiEdzoaArLabel
            // 
            szemelyiEdzoaArLabel.AutoSize = true;
            szemelyiEdzoaArLabel.BackColor = Color.Transparent;
            szemelyiEdzoaArLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            szemelyiEdzoaArLabel.ForeColor = SystemColors.ControlLightLight;
            szemelyiEdzoaArLabel.Location = new Point(651, 476);
            szemelyiEdzoaArLabel.Name = "szemelyiEdzoaArLabel";
            szemelyiEdzoaArLabel.Size = new Size(270, 25);
            szemelyiEdzoaArLabel.TabIndex = 14;
            szemelyiEdzoaArLabel.Text = "Személyi edzés ára 6000 Ft/óra";
            // 
            // csoportosEdzesArLabel
            // 
            csoportosEdzesArLabel.AutoSize = true;
            csoportosEdzesArLabel.BackColor = Color.Transparent;
            csoportosEdzesArLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            csoportosEdzesArLabel.ForeColor = SystemColors.ControlLightLight;
            csoportosEdzesArLabel.Location = new Point(823, 595);
            csoportosEdzesArLabel.Name = "csoportosEdzesArLabel";
            csoportosEdzesArLabel.Size = new Size(349, 25);
            csoportosEdzesArLabel.TabIndex = 15;
            csoportosEdzesArLabel.Text = "Minden csoportos edzés ára 4000 Ft/óra";
            // 
            // WebshopListView
            // 
            WebshopListView.BackColor = SystemColors.MenuText;
            WebshopListView.Columns.AddRange(new ColumnHeader[] { ProductName, ProductPrice });
            WebshopListView.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            WebshopListView.ForeColor = SystemColors.Window;
            WebshopListView.Location = new Point(473, 209);
            WebshopListView.Name = "WebshopListView";
            WebshopListView.Size = new Size(338, 397);
            WebshopListView.TabIndex = 16;
            WebshopListView.UseCompatibleStateImageBehavior = false;
            WebshopListView.View = View.Details;
            // 
            // ProductName
            // 
            ProductName.Text = "Termék neve";
            ProductName.Width = 200;
            // 
            // ProductPrice
            // 
            ProductPrice.Text = "Ár";
            ProductPrice.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(328, 115);
            label1.Name = "label1";
            label1.Size = new Size(575, 37);
            label1.TabIndex = 17;
            label1.Text = "Jelenleg elérhető termékek a webshopunkból:";
            // 
            // indulo_felulet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 198, 249);
            BackgroundImage = Properties.Resources.sotetbgr;
            ClientSize = new Size(1184, 661);
            Controls.Add(label1);
            Controls.Add(WebshopListView);
            Controls.Add(fokep);
            Controls.Add(csoportosEdzesArLabel);
            Controls.Add(szemelyiEdzoaArLabel);
            Controls.Add(edzok_felsorolas);
            Controls.Add(tajekoztatoLabel);
            Controls.Add(szolgLabel);
            Controls.Add(comboBox1);
            Controls.Add(fogado_szoveg);
            Controls.Add(bejiregi);
            Controls.Add(cim);
            Controls.Add(fomenu);
            Controls.Add(textBoxRolunk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = fomenu;
            Margin = new Padding(2);
            Name = "indulo_felulet";
            Text = "Kezdőoldal";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            ((System.ComponentModel.ISupportInitialize)fokep).EndInit();
            fomenu.ResumeLayout(false);
            fomenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fitnessDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource).EndInit();
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
        private Label fogado_szoveg;
        private ComboBox comboBox1;
        private Label szolgLabel;
        private TextBox textBoxRolunk;
        private BindingSource dataBindingSource1;
        private BindingSource fitnessDbContextBindingSource;
        private BindingSource dataBindingSource;
        private Label tajekoztatoLabel;
        private ListBox edzok_felsorolas;
        private Label szemelyiEdzoaArLabel;
        private Label csoportosEdzesArLabel;
        private ListView WebshopListView;
        private ColumnHeader ProductName;
        private ColumnHeader ProductPrice;
        private Label label1;
    }
}