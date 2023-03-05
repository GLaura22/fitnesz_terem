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

namespace fitnesz_terem
{
    public partial class Regisztracio : Form
    {
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
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Regisztráció sikertelen. ('{exception.Message}')");
            }
        }
    }
}
