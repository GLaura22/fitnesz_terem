using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fitnesz_terem
{
    public partial class Regisztracio : Form
    {

        private Rectangle cimRect;
        private Rectangle regicimRect;
        private Rectangle label1Rect;
        private Rectangle label2Rect;
        private Rectangle label3Rect;
        private Rectangle label4Rect;
        private Rectangle label5Rect;
        private Rectangle label6Rect;
        private Rectangle label7Rect;
        private Rectangle label8Rect;
        private Rectangle label9Rect;
        private Rectangle veznevboxRect;
        private Rectangle kernevboxRect;
        private Rectangle kartyakodboxRect;
        private Rectangle jelszoboxRect;
        private Rectangle jelszoismboxRect;
        private Rectangle emailboxRect;
        private Rectangle lejaratiboxRect;
        private Rectangle felhnevboxRect;
        private Rectangle bankszamlaboxRect;
        private Rectangle groupBox1Rect;
        private Rectangle groupBox2Rect;
        private Rectangle groupBox3Rect;
        private Rectangle pictureBox1Rect;
        private Rectangle pictureBox2Rect;
        private Rectangle pictureBox3Rect;
        private Rectangle button1Rect;

        private Size FormSize;
        public Regisztracio()
        {
            InitializeComponent();
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                /* Initialize UserController. */
                UserController userController = new();

                //==============================
                // Validation(s)
                //==============================

                /* TODO: Add more fields to Database
                   Few of the fields that we are having in the form are
                   not getting stored in the database.
                   In my opinion we
                   should consider saving them also. For example the
                   following fields: */
                /*
                if (veznevbox.Text == "")
                {
                    throw new Exception("Vezetéknév nem lehet üres!");
                }
                else if (kernevbox.Text == "")
                {
                    throw new Exception("Keresztnévnév nem lehet üres!");
                }
                */

                if (felhnevbox.Text == "")
                {
                    throw new Exception("Felhasználónév nem lehet üres!");
                }
                else if (jelszobox.Text == "")
                {
                    throw new Exception("Jelszó nem lehet üres!");
                }
                else if (jelszobox.Text != jelszoismbox.Text)
                {
                    throw new Exception("A jelszó nem egyezik a megerősítő jelszóval!");
                }
                /* FIXME: Value was either too large or too small for an int32. */
                else if (bankszamlabox.Text == "")
                {
                    throw new Exception("Bankszámlaszám nem lehet üres!");
                }

                /* TODO: Adding more roles
                   The following variable (role) will probably change due more roles.
                   For now I just hard coded 4 as "Guest". */
                int role = 4;

                FitnessUser fitnessUser = new FitnessUser { Role = role };

                //==============================
                // INSERT INTO `FitnessUser`
                //==============================

                /* Insert user into `FitnessUser` table. */
                int userID = userController.InsertIntoFitnessUser(fitnessUser);

                /* Check if the insertion was successful or not. */
                if (userID == 0)
                {
                    /* ERROR occurred! */
                    throw new Exception("Register failed!");
                }

                //==============================
                // INSERT INTO `Datas`
                //==============================

                /* Default value. */
                int startingMoney = 0;

                Data data = new Data
                {
                    UserId = userID,
                    Name = felhnevbox.Text,
                    Password = jelszobox.Text.ToString(),
                    AccountNumber = int.Parse(bankszamlabox.Text),
                    Money = startingMoney
                };

                /* Insert user into `Datas` table. */
                userController.InsertIntoDatas(data);

                MessageBox.Show("Felhasználó sikeresen regisztrálva!");
                this.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Regisztráció sikertelen. ('{exception.Message}')");
            }
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
        private void resizeChildren()
        {
            resizeControl(cimRect, cim);
            resizeControl(regicimRect, regicim);


            resizeControl(label3Rect, label3);
            resizeControl(label4Rect, label4);
            resizeControl(label5Rect, label5);

            resizeControl(label7Rect, label7);
            resizeControl(label8Rect, label8);
            resizeControl(label9Rect, label9);


            resizeControl(kartyakodboxRect, kartyakodbox);
            resizeControl(jelszoboxRect, jelszobox);
            resizeControl(jelszoismboxRect, jelszoismbox);

            resizeControl(lejaratiboxRect, lejaratibox);
            resizeControl(jelszoboxRect, jelszobox);
            resizeControl(felhnevboxRect, felhnevbox);
            resizeControl(bankszamlaboxRect, bankszamlabox);

            resizeControl(lejaratiboxRect, lejaratibox);

            resizeControl(groupBox2Rect, groupBox2);
            resizeControl(groupBox3Rect, groupBox3);

            resizeControl(pictureBox2Rect, pictureBox2);
            resizeControl(pictureBox3Rect, pictureBox3);
            resizeControl(button1Rect, button1);
        }

        private void Regisztracio_Load(object sender, EventArgs e)
        {

            FormSize = this.Size;
            cimRect = new Rectangle(cim.Location.X, cim.Location.Y, cim.Width, cim.Height);
            regicimRect = new Rectangle(regicim.Location.X, regicim.Location.Y, regicim.Width, regicim.Height);


            label3Rect = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            label4Rect = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            label5Rect = new Rectangle(label5.Location.X, label5.Location.Y, label5.Width, label5.Height);

            label7Rect = new Rectangle(label7.Location.X, label7.Location.Y, label7.Width, label7.Height);
            label8Rect = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);
            label9Rect = new Rectangle(label9.Location.X, label9.Location.Y, label9.Width, label9.Height);


            kartyakodboxRect = new Rectangle(kartyakodbox.Location.X, kartyakodbox.Location.Y, kartyakodbox.Width, kartyakodbox.Height);
            jelszoboxRect = new Rectangle(jelszobox.Location.X, jelszobox.Location.Y, jelszobox.Width, jelszobox.Height);
            jelszoismboxRect = new Rectangle(jelszoismbox.Location.X, jelszoismbox.Location.Y, jelszoismbox.Width, jelszoismbox.Height);

            lejaratiboxRect = new Rectangle(lejaratibox.Location.X, lejaratibox.Location.Y, lejaratibox.Width, lejaratibox.Height);
            jelszoboxRect = new Rectangle(jelszobox.Location.X, jelszobox.Location.Y, jelszobox.Width, jelszobox.Height);
            felhnevboxRect = new Rectangle(felhnevbox.Location.X, felhnevbox.Location.Y, felhnevbox.Width, felhnevbox.Height);
            bankszamlaboxRect = new Rectangle(bankszamlabox.Location.X, bankszamlabox.Location.Y, bankszamlabox.Width, bankszamlabox.Height);

            groupBox2Rect = new Rectangle(groupBox2.Location.X, groupBox2.Location.Y, groupBox2.Width, groupBox2.Height);
            groupBox3Rect = new Rectangle(groupBox3.Location.X, groupBox3.Location.Y, groupBox3.Width, groupBox3.Height);

            pictureBox2Rect = new Rectangle(pictureBox2.Location.X, pictureBox2.Location.Y, pictureBox2.Width, pictureBox2.Height);
            pictureBox3Rect = new Rectangle(pictureBox3.Location.X, pictureBox3.Location.Y, pictureBox3.Width, pictureBox3.Height);
            button1Rect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);

        }

        private void Regisztracio_Resize(object sender, EventArgs e)
        {
            resizeChildren();
        }
    }
}
