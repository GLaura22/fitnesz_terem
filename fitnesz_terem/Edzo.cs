using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Controllers;
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
    public partial class Edzo : Form
    {
        public Edzo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            adatbazis();
        }
        private void adatbazis() {
            dataGridView1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            SqlDataAdapter da;

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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text;
            if (string.IsNullOrEmpty(filterText)) adatbazis();
            else {
                if (comboBox1.SelectedIndex == 0)
                {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                con.Open();
            
                SqlCommand dadata = new SqlCommand("SELECT Name FROM Datas WHERE Name LIKE '@valami'", con);
                    dadata.Parameters.AddWithValue("@valami", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(dadata);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                      dataGridView1.DataSource = dt;
                }
                if (comboBox1.SelectedIndex == 1) {

                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                    con.Open();

                    SqlCommand dadata = new SqlCommand("SELECT ClassName FROM TrainingClasses WHERE ClassName LIKE '@valami'", con);
                    dadata.Parameters.AddWithValue("@valami", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(dadata);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            
            }
           
          


        }
    }
}
