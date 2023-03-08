using fitnesz_terem.Database_Backend.Connection;
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

namespace fitnesz_terem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

            // Get the list of roles
            UserController userC = new UserController();
            ItemController itemC = new ItemController();
            // Call the GetUsers() function to get the list of view model objects
            List<UserViewModel> users = userC.GetUsers();
            List<Item> items = itemC.GetItems();
            Users_with_data.DataSource = users;
            Items_with_data.DataSource = items; 


        }

        private void Users_with_data_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the updated data from the DataGridView
            var updatedUser = (UserViewModel)Users_with_data.Rows[e.RowIndex].DataBoundItem;

            // Update the corresponding records in the database
            using (var context = new FitnessDbContext())
            {
                // Retrieve the Data record associated with the user
                var dataRecord = context.Datas.FirstOrDefault(d => d.UserId == updatedUser.UserId);

                if (dataRecord != null)
                {
                    // Update the Data record
                    dataRecord.Name = updatedUser.Name;
                    dataRecord.Password = updatedUser.Password;
                    dataRecord.AccountNumber = updatedUser.AccountNumber;
                    dataRecord.Money = updatedUser.Money;
                }

                // Retrieve the FitnessUser record associated with the user
                var fitnessUserRecord = context.FitnessUsers.FirstOrDefault(u => u.UserID == updatedUser.UserId);

                if (fitnessUserRecord != null)
                {
                    // Update the FitnessUser record
                    fitnessUserRecord.Role = updatedUser.Role;
                }

                // Save the changes to the database
                context.SaveChanges();
            }
        }

        private List<UserViewModel> resetData()
        {
            // Get the list of roles
            UserController forLoad = new UserController();
            List<Role> roles = forLoad.GetRoles();


            // Call the GetUsers() function to get the list of view model objects
            List<UserViewModel> users = forLoad.GetUsers();

            return users;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterText = filter_Text_Box.Text;
            if (string.IsNullOrEmpty(filterText))
            {
                Users_with_data.DataSource = resetData(); // Reset the DataGridView to show all rows
            }
            else
            {
                List<UserViewModel> users = resetData();
                DataTable dt = ConvertToDataTable(users);
                DataView dv = new DataView(dt);
                dv.RowFilter = string.Format("Name LIKE '%{0}%'", filterText);
                Users_with_data.DataSource = dv.ToTable();
            }
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
