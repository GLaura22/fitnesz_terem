using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fitnesz_terem
{
    public partial class Edzo : Form
    {

        private FitnessUser fitnessUser;
        private Belepes f2 = new Belepes();
        private int id; 
        
        public Edzo(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private int coachid;
        public int setcoachID(int coachID)
        {
            return coachid = coachID;
        }
        private void hozzaadvisibility(Boolean a)
        {

            label3.Visible = a;
            label4.Visible = a;
            label5.Visible = a;
            label6.Visible = a;
            label7.Visible = a;
            textBox3.Visible = a;
            textBox4.Visible = a;
            textBox5.Visible = a;
            textBox6.Visible = a;
            textBox7.Visible = a;
            button4.Visible = a;
        }
        private Boolean button3WasClicked = false;
        private Boolean button1WasClicked = false;
        private Boolean button2WasClicked = false;


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1WasClicked == false)
            {
                hozzaadvisibility(true);
                button1WasClicked = true;
            }
            else
            {
                hozzaadvisibility(false);
                button1WasClicked = false;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");


            con.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                SqlDataAdapter dadata = new SqlDataAdapter("SELECT Name FROM Datas", con);
                DataSet ds = new DataSet();
                dadata.Fill(ds);

                con.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }

            }
            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter dadata = new SqlDataAdapter("SELECT ClassName FROM TrainingClasses", con);
                DataSet ds = new DataSet();
                dadata.Fill(ds);

                con.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            adatbazis();
            if (button2WasClicked == false)
            {
                keresesvisibility(true);
                button2WasClicked = true;
            }
            else
            {
                keresesvisibility(false);
                button2WasClicked = false;

            }

        }
        private void keresesvisibility(Boolean a)
        {
            dataGridView1.Visible = a;
            textBox1.Visible = a;
            label2.Visible = a;
            comboBox1.Visible = a;
        }
        private void adatbazis()
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");


            con.Open();
            if (comboBox1.SelectedIndex == 0)
            {
                SqlDataAdapter dadata = new SqlDataAdapter("SELECT Name FROM Datas", con);
                DataSet ds = new DataSet();
                dadata.Fill(ds);

                con.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }

            }
            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter dadata = new SqlDataAdapter("SELECT ClassName FROM TrainingClasses", con);
                DataSet ds = new DataSet();
                dadata.Fill(ds);

                con.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

        private void Edzo_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            con.Open();
            SqlDataAdapter select = new SqlDataAdapter("SELECT Name FROM Datas WHERE Id=@coachID", con);
            select.SelectCommand.Parameters.AddWithValue("@coachID", coachid);
            DataSet ds = new DataSet();
            select.Fill(ds);

            String name = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            con.Close();

            //label1.Text = name + " Edző";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text;
            if (string.IsNullOrEmpty(filterText)) adatbazis();
            else
            {
                dataGridView1.ClearSelection();
                if (comboBox1.SelectedIndex == 0)
                {
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                    con.Open();


                    SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Datas", con);
                    DataTable ta = new DataTable();
                    da.Fill(ta);
                    DataView dt = new DataView(ta);
                    dt.RowFilter = string.Format("Name LIKE '%{0}%'", filterText);

                    dataGridView1.DataSource = dt.ToTable();
                }
                if (comboBox1.SelectedIndex == 1)
                {

                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT ClassName FROM TrainingClasses", con);
                    DataTable ta = new DataTable();
                    da.Fill(ta);
                    DataView dt = new DataView(ta);
                    dt.RowFilter = string.Format("ClassName LIKE '%{0}%'", filterText);

                    dataGridView1.DataSource = dt.ToTable();
                }

            }




        }
        private void torolvisibility(Boolean a)
        {
            textBox2.Visible = a;
            button5.Visible = a;
            label8.Visible = a;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3WasClicked == false)
            {
                torolvisibility(true);
                button3WasClicked = true;
            }
            else
            {
                torolvisibility(false);
                button3WasClicked = false;
            }


        }
        private void kurzustorol()
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            con.Open();


            SqlCommand delete = new SqlCommand("DELETE TrainingClasses WHERE ClassName=@classname", con);
            delete.Parameters.AddWithValue("@classname", textBox2.Text);
            delete.ExecuteNonQuery();




        }

        private void button4_Click(object sender, EventArgs e)
        {

            string message = "Biztos hozzá szeretné adni?";
            string title = "Kurzus hozzáadása";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                kurzushozzad();
                MessageBox.Show("Az új kurzus létre hozva!");
                hozzaadvisibility(false);
            }
            else
            {

            }


        }
        private void kurzushozzad()
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            con.Open();
            SqlCommand add = new SqlCommand("insert into TrainingClasses values(@start,@end,@maxpeople,@location,@classname,@coachID)", con);
            try
            {
                add.Parameters.AddWithValue("@start", DateTime.Parse(textBox3.Text));
            }
            catch
            {
                MessageBox.Show("Nem megfelelő Kezdési idő");
            }
            add.Parameters.AddWithValue("@end", DateTime.Parse(textBox4.Text));
            add.Parameters.AddWithValue("@maxpeople", int.Parse(textBox5.Text));
            add.Parameters.AddWithValue("@location", int.Parse(textBox6.Text));
            add.Parameters.AddWithValue("@classname", textBox7.Text);
            add.Parameters.AddWithValue("@coachID", coachid);
            add.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Biztos szeretné törölni a |" + textBox2.Text + "| kurzust?";
            string title = "Kurzus törlése";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                kurzustorol();
                MessageBox.Show("A " + textBox2.Text + " nevű kurzus törölve lett!");
                torolvisibility(false);
            }
            else
            {

            }


        }
    }
}
