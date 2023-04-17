using fitnesz_terem.Database_Backend.Connection;
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
    public partial class Admin_Feltoltes : Form
    {
        public Admin_Feltoltes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ha az edzo ID-ja es az edzés tipusa együtt már szerepel az adatbázisban
            // --> módosítás // ez nem feltétlen megfelelő, mivel lehet másik időpont, Ez TODO hogy dátumot is nézze.


            // ha nem --> hozzáadás

            using (var context = new FitnessDbContext())
            {
                DateTime start = EdzesStartDate.Value;
                DateTime end = EdzesBefejezesDate.Value;

                string locationName = termekComboBox.SelectedItem.ToString();

                // query the Locations DbSet for the location with the matching name
                Location location = context.Locations.FirstOrDefault(l => l.LocationName == locationName);

                string edzo = (string)EdzoComboBox.SelectedItem;

                int coachID = context.Datas.Where(d => d.Name == edzo)
                                            .Select(d => d.UserId)
                                            .FirstOrDefault();


                // get the max people value from the TextBox

                try
                {
                    int maxPeople = int.Parse(maxLetszamTextBox.Text);

                    // create a new instance of TrainingClass
                    TrainingClass newClass = new TrainingClass()
                    {
                        StartTime = start,
                        EndTime = end,
                        MaxPeople = (int)maxPeople,
                        LocationID = location.LocationID, // example location ID
                        ClassName = (string)EdzesComboBox.SelectedItem, // example class name
                        CoachID = coachID // example coach ID
                    };


                    // add the new record to the TrainingClass DbSet
                    context.TrainingClasses.Add(newClass);

                    // save changes to the database
                    context.SaveChanges();
                    MessageBox.Show("Sikeres adatfelvitel!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            // figyelni hogy terem abban az idopontban szabad legyen --> kulonben hibauzenet
        }

        private void Admin_Feltoltes_Load(object sender, EventArgs e)
        {

            EdzesStartDate.Format = DateTimePickerFormat.Custom;
            EdzesBefejezesDate.Format = DateTimePickerFormat.Custom;
            EdzesBefejezesDate.CustomFormat = "yyyy.  MMM  dd. - hh : mm";
            EdzesStartDate.CustomFormat = "yyyy.  MMM  dd. - hh : mm";

            using(var context = new FitnessDbContext())
            {
                var termek = context.Locations.ToList();
                foreach (var item in termek.Select(c => c.LocationName).Distinct())
                {
                    termekComboBox.Items.Add(item);
                }

                var edzok = context.Datas.Join(
                context.FitnessUsers.Where(u => u.Role == 2),
                d => d.UserId,
                u => u.UserID,
                (d, u) => new { Data = d, FitnessUser = u });

                foreach(var edzo in edzok.Select(c => c.Data.Name).Distinct())
                {
                    EdzoComboBox.Items.Add(edzo);    
                }

                var classes = context.TrainingClasses
                  .GroupBy(tc => tc.ClassName)
                  .Select(g => g.First())
                  .ToList();

                foreach(var clas in classes.Select(c => c.ClassName))
                {
                    EdzesComboBox.Items.Add(clas);
                }
            }
        }


        private void ujTermekButton_Click(object sender, EventArgs e)
        {
            using (var context = new FitnessDbContext())
            {
                string tnev = termeknevTextBox.Text;

                var existingItem = context.Items.FirstOrDefault(i => i.Name == tnev);

                if (existingItem != null)
                {
                    MessageBox.Show("Már van ilyen nevű termék.");
                    return;
                }

                // The item doesn't exist yet, so you can add it to the database
                int ar = int.Parse(arTextBox.Text);
                int rakdb = int.Parse(raktaronTextBox.Text);

                var newItem = new Item
                {
                    Name = tnev,
                    Price = ar,
                    NumberInStock = rakdb
                };

                context.Items.Add(newItem);
                context.SaveChanges();

                // Show a success message to the user, clear the form fields, etc.

                MessageBox.Show($"{tnev} nevű termék sikeresen hozzáadva.");
            }







        }
    }
}
