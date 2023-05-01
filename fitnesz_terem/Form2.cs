using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
    public partial class Form2 : Form
    {
        private int CoachID = 1; // át kell írni 0 rá ha jó a coachID-ja a BoB Leenek mert nálam 0 + a
                                 // létrehozásnál is az edzőnél ki kell venni a set-es commentet meg
                                 // itt lent is a 102. sorban
        private int IDk = 0;
        public Form2()
        {
            InitializeComponent();
            IDk = ID;
            rajz(IDk, CoachID);
            
        }
        public void rajz(int userID = 0, int coachID = 0)
        {
            if (userID != 0)
            {
                string connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand($"SELECT ClassID FROM usersToClasses where UserID={userID}", connection);

                SqlCommand command2 = new SqlCommand("SELECT * FROM TrainingClasses", connection);

                DateTime selectedDate = monthCalendar1.SelectionRange.Start;

                SqlDataReader reader = command.ExecuteReader();
                List<int> data = new List<int>();
                while (reader.Read())
                {
                    int item = (int)reader[0]; // az 0. oszlop adatait adja hozzá a listához
                    data.Add(item);

                }
                reader.Close();



                SqlDataReader reader2 = command2.ExecuteReader();


                while (reader2.Read())
                {
                    DateTime start = DateTime.Parse(reader2["StartTime"].ToString());

                    if (start.Year == monthCalendar1.SelectionRange.Start.Year &&
                        start.Month == monthCalendar1.SelectionRange.Start.Month &&
                        start.Day == monthCalendar1.SelectionRange.Start.Day)
                    {

                        foreach (int valami in data)
                        {

                            if (valami == (int)reader2["ClassID"])
                            {


                                DateTime start2 = DateTime.Parse(reader2["StartTime"].ToString());
                                DateTime end = DateTime.Parse(reader2["EndTime"].ToString());
                                int y = 10 + (start2.Hour - 8) * 40 + start2.Minute / 60 * 40;
                                int y2 = (end.Hour - start2.Hour) * 40;
                                Panel panel2 = new Panel();
                                panel2.Location = new Point(320, y);
                                panel2.Size = new Size(150, y2);
                                panel2.BackColor = Color.Blue;
                                Label label1 = new Label();
                                label1.Text = "" + reader2["ClassName"] + ": " + (DateTime.Parse(reader2["StartTime"].ToString())).Hour + ":" + "" + (DateTime.Parse(reader2["StartTime"].ToString())).Minute.ToString("d2") + "-" + "" + (DateTime.Parse(reader2["EndTime"].ToString())).Hour + ":" + (DateTime.Parse(reader2["EndTime"].ToString())).Minute.ToString("d2") + "";
                                label1.Location = new Point(20, 0);
                                label1.AutoSize = true;
                                label1.ForeColor = Color.Red;
                                panel2.Controls.Add(label1);
                                this.Controls.Add(panel2);

                            }
                        }
                    }

                }
                reader2.Close();
                connection.Close();


            }
            else
            {
                string connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command2 = new SqlCommand("SELECT * FROM TrainingClasses where CoachID =1", connection);
                //SqlCommand command2 = new SqlCommand($"SELECT * FROM TrainingClasses where CoachID ={coachID}", connection);
                DateTime selectedDate = monthCalendar1.SelectionRange.Start;
                SqlDataReader reader2 = command2.ExecuteReader();


                while (reader2.Read())
                {
                    DateTime start = DateTime.Parse(reader2["StartTime"].ToString());

                    if (start.Year == monthCalendar1.SelectionRange.Start.Year &&
                        start.Month == monthCalendar1.SelectionRange.Start.Month &&
                        start.Day == monthCalendar1.SelectionRange.Start.Day)
                    {

                        DateTime start2 = DateTime.Parse(reader2["StartTime"].ToString());
                        DateTime end = DateTime.Parse(reader2["EndTime"].ToString());
                        int y = 10 + (start2.Hour - 8) * 40 + start2.Minute / 60 * 40;
                        int y2 = (end.Hour - start2.Hour) * 40;
                        Panel panel2 = new Panel();
                        panel2.Location = new Point(320, y);
                        panel2.Size = new Size(150, y2);
                        panel2.BackColor = Color.Blue;
                        Label label1 = new Label();
                        label1.Text = "" + reader2["ClassName"] + ": " + (DateTime.Parse(reader2["StartTime"].ToString())).Hour + ":" + "" + (DateTime.Parse(reader2["StartTime"].ToString())).Minute.ToString("d2") + "-" + "" + (DateTime.Parse(reader2["EndTime"].ToString())).Hour + ":" + (DateTime.Parse(reader2["EndTime"].ToString())).Minute.ToString("d2") + "";
                        label1.Location = new Point(20, 0);
                        label1.AutoSize = true;
                        label1.ForeColor = Color.Red;
                        panel2.Controls.Add(label1);
                        this.Controls.Add(panel2);



                    }

                }
                reader2.Close();
                connection.Close();

            }


        }
        public void setcoachID(int IDs) {
            CoachID = IDs;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (IDk == 0)
            {
                foreach (Control control in Controls.OfType<Panel>().ToList())
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
                rajz(ID);
            }
            else {
                foreach (Control control in Controls.OfType<Panel>().ToList())
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
                rajz(0,CoachID);
            }
            
            
        }
    }
}
