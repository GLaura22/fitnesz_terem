using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
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
    public partial class Admin_Jogosultsagok : Form
    {
        public Admin_Jogosultsagok()
        {
            InitializeComponent();
        }

        private void Edzo_Hozzaadas_Button_Click(object sender, EventArgs e)
        {
            try 
            {
                UserController userController = new();
                if (edzoNevTextBox.Text == "")
                {
                    throw new Exception("Felhasználónév nem lehet üres!");
                }
                else if (edzoJelszoTextBox.Text == "")
                {
                    throw new Exception("Jelszó nem lehet üres!");
                }

                // most csak edzo jogosultsagu felhasznalokat viszunk fel
                int role = 2;

                FitnessUser fitnessUser = new FitnessUser { Role = role };

                /* Insert coach into `FitnessUser` table. */
                int userID = userController.InsertIntoFitnessUser(fitnessUser);

                /* Check if the insertion was successful or not. */
                if (userID == 0)
                {
                    /* ERROR occurred! */
                    throw new Exception("Register failed!");
                }

                //==============================
                // INSERT INTO `Datas` <3
                //==============================

                /* Default value. */
                //edzok amugy sem vasarolhatnak + felesleges berlet
                int startingMoney = 0;
                int startingLease = -1;
                int accountNumber = 0;

                Data data = new Data
                {
                    UserId = userID,
                    Name = edzoNevTextBox.Text,
                    Password = edzoJelszoTextBox.Text.ToString(),
                    AccountNumber = accountNumber,
                    Money = startingMoney,
                    Lease = startingLease
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

        private void Torles_Button_Click(object sender, EventArgs e)
        {
            /*
            var object = context.collection.Find(id);
            context.collection.Remove(object);
            context.SaveChanges();
            */
            try
            {
                UserController userController = new();
                int userId = int.Parse(torlendoFelhId.Text);

               // bool sikeres_torles = false;

                if (!userController.RemoveFromFitnessUsers(userId))
                {
                    MessageBox.Show("Nincs felhasználó ilyen id-val az adatbázisban (FitnessUser tabla).");
                    return;
                }
                else if (!userController.RemoveFromDatas(userId))
                {
                    MessageBox.Show("Nincs felhasználó ilyen id-val az adatbázisban (Datas tabla).");
                    return;
                }

                
                MessageBox.Show("Felhasználó sikeresen törölve!");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Regisztráció sikertelen. ('{exception.Message}')");
            }
        }
    }
}
