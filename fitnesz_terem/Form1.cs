namespace fitnesz_terem
{
    public partial class indulo_felulet : Form
    {
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
    }
}