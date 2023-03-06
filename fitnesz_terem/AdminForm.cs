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
            UserController forLoad = new UserController();
            List<Role> roles = forLoad.GetRoles();

            // Clear any existing items in the ComboBox
            comboBox1.Items.Clear();

            // Add each role to the ComboBox
            foreach (Role role in roles)
            {
                comboBox1.Items.Add(role.Label); // Replace "Name" with the property of the Role object that you want to display in the ComboBox
            }

            comboBox1.SelectedIndex = 0;

            // Call the GetUsers() function to get the list of view model objects
            List<UserViewModel> users = forLoad.GetUsers();

            Users_with_data.DataSource = users;
        }
    }
}
