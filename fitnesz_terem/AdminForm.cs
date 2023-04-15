using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
using fitnesz_terem.Admin_Funkciok;
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

            // Create an instance of your EF DbContext
            using (var context = new FitnessDbContext())
            {
                // Query the Roles data from the database using the DbSet property of your DbContext
                var roles = context.Roles.ToList();

                // Create a new DataTable and add columns
                var dataTable = new DataTable();
                dataTable.Columns.Add("RoleID", typeof(int));
                dataTable.Columns.Add("Label", typeof(string));

                // Populate the DataTable with data from the Roles list
                foreach (var role in roles)
                {
                    var row = dataTable.NewRow();
                    row["RoleID"] = role.RoleID;
                    row["Label"] = role.Label;
                    dataTable.Rows.Add(row);
                }

                // Bind the DataTable to your roleBox control
                roleBox.DataSource = dataTable;
                roleBox.DisplayMember = "Label";
                roleBox.ValueMember = "RoleID";
            }



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

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new FitnessDbContext())
            {
                // Get the selected role index from the roleBox ComboBox
                int selectedRoleIndex = roleBox.SelectedIndex;

                if (selectedRoleIndex == 0)
                {
                    // If index 0 is selected, show only users with RoleID 1
                    List<UserViewModel> users = context.Datas.Join(context.FitnessUsers, d => d.UserId, u => u.UserID, (d, u) => new UserViewModel
                    {
                        UserId = d.UserId,
                        Name = d.Name,
                        Password = d.Password,
                        AccountNumber = d.AccountNumber,
                        Money = d.Money,
                        Role = u.Role
                    })
                    .Where(u => u.Role == 1)
                    .ToList();
                    Users_with_data.DataSource = ConvertToDataTable(users);
                }
                else if (selectedRoleIndex == 1)
                {
                    // If index 1 is selected, show only users with RoleID 2
                    List<UserViewModel> users = context.Datas.Join(context.FitnessUsers, d => d.UserId, u => u.UserID, (d, u) => new UserViewModel
                    {
                        UserId = d.UserId,
                        Name = d.Name,
                        Password = d.Password,
                        AccountNumber = d.AccountNumber,
                        Money = d.Money,
                        Role = u.Role
                    })
                    .Where(u => u.Role == 2)
                    .ToList();
                    Users_with_data.DataSource = ConvertToDataTable(users);
                }
                else if (selectedRoleIndex == 2)
                {
                    // If index 2 is selected, show only users with RoleID 3
                    List<UserViewModel> users = context.Datas.Join(context.FitnessUsers, d => d.UserId, u => u.UserID, (d, u) => new UserViewModel
                    {
                        UserId = d.UserId,
                        Name = d.Name,
                        Password = d.Password,
                        AccountNumber = d.AccountNumber,
                        Money = d.Money,
                        Role = u.Role
                    })
                    .Where(u => u.Role == 3)
                    .ToList();
                    Users_with_data.DataSource = ConvertToDataTable(users);
                }
                else
                {
                    // If no index is selected, show all users
                    Users_with_data.DataSource = resetData();
                }
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

        private void jogosultságokKezeléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Regisztracio f3 = new Regisztracio();
            //f3.ShowDialog();

            Admin_Jogosultsagok a1 = new Admin_Jogosultsagok();
            a1.ShowDialog();
        }

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Feltoltes a2 = new Admin_Feltoltes();
            a2.ShowDialog();
        }
    }
}
