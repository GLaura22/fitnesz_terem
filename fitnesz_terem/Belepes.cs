using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnesz_terem
{
    public partial class Belepes : Form
    {
        public Belepes()
        {
            InitializeComponent();
        }

        private void regilabel_Click(object sender, EventArgs e)
        {
            Regisztracio f3 = new Regisztracio();
            f3.ShowDialog();
            this.Close();
        }
    }
}
