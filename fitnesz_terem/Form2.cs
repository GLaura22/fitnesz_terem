using Microsoft.Data.SqlClient;
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
        public Form2()
        {
            InitializeComponent();
            rajz();
        }
        public void rajz()
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ClassID FROM usersToClasses where UserID=3", connection);
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
                            int y = 10 + (start2.Hour - 8) * 40 + start2.Minute /60 * 40;
                            int y2 = (end.Hour - start2.Hour) * 40;
                            Panel panel2 = new Panel();
                            panel2.Location = new Point(320, y);
                            panel2.Size = new Size(150, y2);
                            panel2.BackColor = Color.Blue;
                            Label label1 = new Label();
                            label1.Text = "" + reader2["ClassName"]+": " + (DateTime.Parse(reader2["StartTime"].ToString())).Hour + ":" +""+ (DateTime.Parse(reader2["StartTime"].ToString())).Minute.ToString("d2") + "-" +""+ (DateTime.Parse(reader2["EndTime"].ToString())).Hour + ":"+(DateTime.Parse(reader2["EndTime"].ToString())).Minute.ToString("d2") + "";
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

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            foreach (Control control in Controls.OfType<Panel>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }
            rajz();
        }
    }
}
