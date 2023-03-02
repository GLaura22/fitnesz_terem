namespace fitnesz_terem
{
    public partial class indulo_felulet : Form
    {
        private Rectangle cimRect;
        private Rectangle bejiregiRect;
        private Rectangle fokepRect;
        private Rectangle fomenuRect;
        private Rectangle textBoxRolunkRect;
        private Rectangle fogado_szovegRect;

        private Size FormSize;

        private void resizeChildren()
        {
            resizeControl(cimRect, cim);
            resizeControl(bejiregiRect, bejiregi);
            resizeControl(fokepRect, fokep);
            resizeControl(fomenuRect, fomenu);
            resizeControl(textBoxRolunkRect, textBoxRolunk);
            resizeControl(fogado_szovegRect, fogado_szoveg);




        }
        private void resizeControl(Rectangle Rect, Control control)
        {
            float xRation = (float)(this.Width) / (float)(FormSize.Width);
            float yRation = (float)(this.Height) / (float)(FormSize.Height);

            int newX = (int)(Rect.X * xRation);
            int newY = (int)(Rect.Y * yRation);
            int newWeight = (int)(Rect.Width * xRation);
            int newHeight = (int)(Rect.Height * yRation);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWeight, newHeight);
        }

        public indulo_felulet()
        {
            InitializeComponent();
            textBoxRolunk.Visible = false;
            fogado_szoveg.BorderStyle = BorderStyle.None;
            textBoxRolunk.BorderStyle = BorderStyle.None;
        }

        private void formenu1_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = true;
            fogado_szoveg.Visible = false;
        }

        private void foszmenu2_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = false;
            fogado_szoveg.Visible = false;

        }

        private void bejiregi_Click(object sender, EventArgs e)
        {
            Belepes f2 = new Belepes();
            f2.ShowDialog();
        }

        private void indulo_felulet_Resize(object sender, EventArgs e)
        {
            resizeChildren();
        }

        private void indulo_felulet_Load(object sender, EventArgs e)
        {
            FormSize = this.Size;
            cimRect = new Rectangle(cim.Location.X, cim.Location.Y, cim.Width, cim.Height);
            bejiregiRect = new Rectangle(bejiregi.Location.X, bejiregi.Location.Y, bejiregi.Width, bejiregi.Height);
            fokepRect = new Rectangle(fokep.Location.X, fokep.Location.Y, fokep.Width, fokep.Height);
            fomenuRect = new Rectangle(fomenu.Location.X, fomenu.Location.Y, fomenu.Width, fomenu.Height);
            textBoxRolunkRect = new Rectangle(textBoxRolunk.Location.X, textBoxRolunk.Location.Y, textBoxRolunk.Width, textBoxRolunk.Height);
            fogado_szovegRect = new Rectangle(fogado_szoveg.Location.X, fogado_szoveg.Location.Y, fogado_szoveg.Width, fogado_szoveg.Height);

        }
    }
}