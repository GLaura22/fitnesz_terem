using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fitnesz_terem
{

    public partial class Belepes : Form
    {
        private Rectangle felhlabelRect;
        private Rectangle jelszolabelRect;
        private Rectangle textBox1Rect;
        private Rectangle textBox2Rect;
        private Rectangle cimRect;
        private Rectangle regilabelRect;

        private Size FormSize;
        public FitnessUser felhasznalo;

        private void resizeChildren()
        {
            resizeControl(felhlabelRect, felhlabel);
            resizeControl(jelszolabelRect, jelszolabel);
            resizeControl(textBox1Rect, textBox1);
            resizeControl(textBox2Rect, textBox2);
            resizeControl(cimRect, cim);
            resizeControl(regilabelRect, regilabel);

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
        public Belepes()
        {
            InitializeComponent();
            felhasznalo = new FitnessUser { UserID = 0, DataId = 0, Role = 0 };

        }
        private void Belepes_Resize(object sender, EventArgs e)
        {
            resizeChildren();
        }


        private void belepButton_Click(object sender, EventArgs e)
        {
            try
            {
                /* Initialize UserController. */
                UserController userController = new();

                //==============================
                // Validation(s)
                //==============================


                if (textBox1.Text == "")
                {
                    throw new Exception("Felhasználónév nem lehet üres!");
                }
                else if (textBox2.Text == "")
                {
                    throw new Exception("Jelszó nem lehet üres!");
                }

                felhasznalo = userController.Login(textBox1.Text, textBox2.Text);

                if (felhasznalo.UserID == 0)
                {
                    throw new Exception("Felhasználónév vagy jelszó helytelen!");
                }

                MessageBox.Show("Felhasználó sikeresen bejelentkezve!");
                if (textBox1.Text == "Bob Lee")
                {
                    Edzo e1 = new Edzo();
                    e1.setcoachID(3);
                    e1.ShowDialog();


                }
                if (textBox1.Text == "David Kim")
                {
                    Edzo e1 = new Edzo();
                    e1.setcoachID(4);
                    e1.ShowDialog();


                }
                if (textBox1.Text == "Emily Chen")
                {
                    Edzo e1 = new Edzo();
                    e1.setcoachID(5);
                    e1.ShowDialog();


                }
                if (textBox1.Text == "Isabella Wu")
                {
                    Edzo e1 = new Edzo();
                    e1.setcoachID(9);
                    e1.ShowDialog();


                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Bejelentkezés sikertelen. ('{exception.Message}')");
            }
        }


        private void regilabel_Click(object sender, EventArgs e)
        {
            Regisztracio f3 = new Regisztracio();
            f3.ShowDialog();
            //this.Close();
        }

        private void Belepes_Load(object sender, EventArgs e)
        {
            FormSize = this.Size;
            cimRect = new Rectangle(cim.Location.X, cim.Location.Y, cim.Width, cim.Height);
            felhlabelRect = new Rectangle(felhlabel.Location.X, felhlabel.Location.Y, felhlabel.Width, felhlabel.Height);
            jelszolabelRect = new Rectangle(jelszolabel.Location.X, jelszolabel.Location.Y, jelszolabel.Width, jelszolabel.Height);
            textBox1Rect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            textBox2Rect = new Rectangle(textBox2.Location.X, textBox2.Location.Y, textBox2.Width, textBox2.Height);
            regilabelRect = new Rectangle(regilabel.Location.X, regilabel.Location.Y, regilabel.Width, regilabel.Height);
        }

        public FitnessUser UserId()
        {
            this.ShowDialog();
            return felhasznalo;
        }
    }
}
