using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnesz_terem.Admin_Funkciok
{
    public partial class Admin_Feltoltes : Form
    {
        public Admin_Feltoltes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ha az edzo ID-ja es az edzés tipusa együtt már szerepel az adatbázisban
            // --> módosítás
            // ha nem --> hozzáadás
            // figyelni hogy terem abban az idopontban szabad legyen --> kulonben hibauzenet
        }
    }
}
