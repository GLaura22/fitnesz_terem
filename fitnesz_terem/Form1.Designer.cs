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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cim = new System.Windows.Forms.Label();
            this.bejiregi = new System.Windows.Forms.Label();
            this.fokep = new System.Windows.Forms.PictureBox();
            this.fomenu = new System.Windows.Forms.MenuStrip();
            this.formenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.foszmenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.foemenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fowmenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fogado_szoveg = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.szolgLabel = new System.Windows.Forms.Label();
            this.textBoxRolunk = new System.Windows.Forms.TextBox();
            this.edzok_felsorolas = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessDbContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tajekoztatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fokep)).BeginInit();
            this.fomenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edzok_felsorolas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDbContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cim
            // 
            this.cim.AutoSize = true;
            this.cim.BackColor = System.Drawing.Color.Transparent;
            this.cim.Dock = System.Windows.Forms.DockStyle.Left;
            this.cim.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cim.ForeColor = System.Drawing.Color.White;
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
            this.bejiregi.BackColor = System.Drawing.Color.Transparent;
            this.bejiregi.Dock = System.Windows.Forms.DockStyle.Top;
            this.bejiregi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.bejiregi.ForeColor = System.Drawing.Color.White;
            this.bejiregi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bejiregi.Location = new System.Drawing.Point(344, 24);
            this.bejiregi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bejiregi.Name = "bejiregi";
            this.bejiregi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bejiregi.Size = new System.Drawing.Size(840, 20);
            this.bejiregi.TabIndex = 1;
            this.bejiregi.Text = "Bejelentkezés/Regisztráció";
            this.bejiregi.Click += new System.EventHandler(this.bejiregi_Click);
            // 
            // fokep
            // 
            this.fokep.BackColor = System.Drawing.Color.Transparent;
            this.fokep.Image = global::fitnesz_terem.Properties.Resources.gym_hatter;
            this.fokep.Location = new System.Drawing.Point(344, 137);
            this.fokep.Margin = new System.Windows.Forms.Padding(2);
            this.fokep.Name = "fokep";
            this.fokep.Size = new System.Drawing.Size(545, 296);
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
            this.fomenu.Size = new System.Drawing.Size(1184, 24);
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
            this.foemenu3.Click += new System.EventHandler(this.foemenu3_Click);
            // 
            // fowmenu4
            // 
            this.fowmenu4.Name = "fowmenu4";
            this.fowmenu4.Size = new System.Drawing.Size(110, 22);
            this.fowmenu4.Text = " Webshop kínálat";
            // 
            // fogado_szoveg
            // 
            this.fogado_szoveg.AutoSize = true;
            this.fogado_szoveg.BackColor = System.Drawing.Color.Transparent;
            this.fogado_szoveg.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fogado_szoveg.ForeColor = System.Drawing.Color.White;
            this.fogado_szoveg.Location = new System.Drawing.Point(315, 530);
            this.fogado_szoveg.Name = "fogado_szoveg";
            this.fogado_szoveg.Size = new System.Drawing.Size(644, 40);
            this.fogado_szoveg.TabIndex = 7;
            this.fogado_szoveg.Text = "Üdvözlünk a Balaton fitness terem honlapján!";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(565, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // szolgLabel
            // 
            this.szolgLabel.AutoSize = true;
            this.szolgLabel.BackColor = System.Drawing.Color.Transparent;
            this.szolgLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.szolgLabel.ForeColor = System.Drawing.Color.White;
            this.szolgLabel.Location = new System.Drawing.Point(195, 500);
            this.szolgLabel.Name = "szolgLabel";
            this.szolgLabel.Size = new System.Drawing.Size(306, 32);
            this.szolgLabel.TabIndex = 9;
            this.szolgLabel.Text = "Elérhető szolgáltatásaink:";
            // 
            // textBoxRolunk
            // 
            this.textBoxRolunk.BackColor = System.Drawing.Color.Black;
            this.textBoxRolunk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRolunk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRolunk.ForeColor = System.Drawing.Color.White;
            this.textBoxRolunk.Location = new System.Drawing.Point(403, 542);
            this.textBoxRolunk.Multiline = true;
            this.textBoxRolunk.Name = "textBoxRolunk";
            this.textBoxRolunk.Size = new System.Drawing.Size(462, 114);
            this.textBoxRolunk.TabIndex = 10;
            this.textBoxRolunk.Text = "Egy modern, jól felszerelt edzőtermet üzemeltetünk a Balaton partján mindenkinek," +
    " aki egyedül vagy csoportban szeretne sportolni.  Várunk szeretettel, ha neked i" +
    "s fontos az egészséges életmód. ";
            this.textBoxRolunk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edzok_felsorolas
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            this.edzok_felsorolas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.edzok_felsorolas.AutoGenerateColumns = false;
            this.edzok_felsorolas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edzok_felsorolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edzok_felsorolas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.edzok_felsorolas.DataSource = this.dataBindingSource1;
            this.edzok_felsorolas.GridColor = System.Drawing.Color.Black;
            this.edzok_felsorolas.Location = new System.Drawing.Point(383, 301);
            this.edzok_felsorolas.Name = "edzok_felsorolas";
            this.edzok_felsorolas.RowTemplate.Height = 25;
            this.edzok_felsorolas.Size = new System.Drawing.Size(467, 258);
            this.edzok_felsorolas.TabIndex = 11;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataBindingSource1
            // 
            this.dataBindingSource1.DataSource = typeof(fitnesz_terem.Database_Backend.Modells_Tables.Data);
            // 
            // fitnessDbContextBindingSource
            // 
            this.fitnessDbContextBindingSource.DataSource = typeof(fitnesz_terem.Database_Backend.Connection.FitnessDbContext);
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(fitnesz_terem.Database_Backend.Modells_Tables.Data);
            // 
            // tajekoztatoLabel
            // 
            this.tajekoztatoLabel.AutoSize = true;
            this.tajekoztatoLabel.BackColor = System.Drawing.Color.Transparent;
            this.tajekoztatoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tajekoztatoLabel.ForeColor = System.Drawing.Color.White;
            this.tajekoztatoLabel.Location = new System.Drawing.Point(371, 184);
            this.tajekoztatoLabel.Name = "tajekoztatoLabel";
            this.tajekoztatoLabel.Size = new System.Drawing.Size(494, 32);
            this.tajekoztatoLabel.TabIndex = 12;
            this.tajekoztatoLabel.Text = "Minden edzőnk vállal személyes edzést is!";
            // 
            // indulo_felulet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(198)))), ((int)(((byte)(249)))));
            this.BackgroundImage = global::fitnesz_terem.Properties.Resources.sotetbgr;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tajekoztatoLabel);
            this.Controls.Add(this.edzok_felsorolas);
            this.Controls.Add(this.szolgLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fogado_szoveg);
            this.Controls.Add(this.fokep);
            this.Controls.Add(this.bejiregi);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.fomenu);
            this.Controls.Add(this.textBoxRolunk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.fomenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "indulo_felulet";
            this.Text = "Kezdőoldal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            ((System.ComponentModel.ISupportInitialize)(this.fokep)).EndInit();
            this.fomenu.ResumeLayout(false);
            this.fomenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edzok_felsorolas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessDbContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
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
        private Label fogado_szoveg;
        private ComboBox comboBox1;
        private Label szolgLabel;
        private TextBox textBoxRolunk;
        private DataGridView edzok_felsorolas;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource dataBindingSource1;
        private BindingSource fitnessDbContextBindingSource;
        private BindingSource dataBindingSource;
        private Label tajekoztatoLabel;
    }
}