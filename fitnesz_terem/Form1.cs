using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
using System.Data;

namespace fitnesz_terem
{
    public partial class indulo_felulet : Form
    {
        private FitnessUser fitnessUser;
        private Belepes f2 = new Belepes();

        private Rectangle cimRect;
        private Rectangle bejiregiRect;
        private Rectangle fokepRect;
        private Rectangle fomenuRect;
        private Rectangle textBoxRolunkRect;
        private Rectangle fogado_szovegRect;
        private Size FormSize;

        Bitmap yoga = Properties.Resources.yoga;
        Bitmap spinning = Properties.Resources.spinning;
        Bitmap altalanos = Properties.Resources.gym_hatter;
        Bitmap pilates = Properties.Resources.pilates;


        public indulo_felulet()
        {
            InitializeComponent();
            fitnessUser = new FitnessUser{ UserID = 0, DataId = 0, Role = 0 };
            textBoxRolunk.Visible= false;
            fogado_szoveg.BorderStyle = BorderStyle.None;
            textBoxRolunk.BorderStyle = BorderStyle.None;
            comboBox1.Visible = false;
            szolgLabel.Visible = false;
            fokep.Image = altalanos;
            
        }

        private void formenu1_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = true;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = false;
        }

        private void foszmenu2_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = false;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = true;
            szolgLabel.Visible = true;
            /*
            // Get the list of roles
            UserController userC = new UserController();
            ItemController itemC = new ItemController();
            // Call the GetUsers() function to get the list of view model objects
            List<UserViewModel> users = userC.GetUsers();
            List<Item> items = itemC.GetItems();
            Users_with_data.DataSource = users;
            Items_with_data.DataSource = items; */

            using (var context = new FitnessDbContext())
            {
                // Query the Roles data from the database using the DbSet property of your DbContext
                var classes = context.TrainingClasses.ToList();

                // Create a new DataTable and add columns
                var dataTable = new DataTable();
                dataTable.Columns.Add("ClassName", typeof(string));

                // Populate the DataTable with data from the Roles list
                foreach (var c in classes)
                {
                    var row = dataTable.NewRow();
                    row["ClassName"] = c.ClassName;
                    dataTable.Rows.Add(row);

                /*
                    var row = dataTable.NewRow();
                    row["RoleID"] = role.RoleID;
                    row["Label"] = role.Label;
                    dataTable.Rows.Add(row);    */
                }

                // Bind the DataTable to your roleBox control
                //roleBox.DataSource = dataTable;
                //roleBox.DisplayMember = "Label";
                //roleBox.ValueMember = "RoleID";

                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember= "Name";
                comboBox1.ValueMember= "ClassName";

                 
            }

        }

        private void bejiregi_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(f2.UserId().UserID.ToString());
        }
        private void resizeChildren()
        {
            resizeControl(cimRect, cim);
            resizeControl(bejiregiRect, bejiregi);
            resizeControl(fokepRect, fokep);
            resizeControl(fomenuRect, fomenu);
            resizeControl(textBoxRolunkRect, textBoxRolunk);
            resizeControl(fogado_szovegRect, fogado_szoveg);
        }
        private void resizeControl(Rectangle Rect, Control control)
        {
            float xRation = (float)(this.Width) / (float)(FormSize.Width);
            float yRation = (float)(this.Height) / (float)(FormSize.Height);

            int newX = (int)(Rect.X * xRation);
            int newY = (int)(Rect.Y * yRation);
            int newWeight = (int)(Rect.Width * xRation);
            int newHeight = (int)(Rect.Height * yRation);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWeight, newHeight);
        }

        private void indulo_felulet_Load(object sender, EventArgs e)
        {
            FormSize = this.Size;
            cimRect = new Rectangle(cim.Location.X, cim.Location.Y, cim.Width, cim.Height);
            bejiregiRect = new Rectangle(bejiregi.Location.X, bejiregi.Location.Y, bejiregi.Width, bejiregi.Height);
            fokepRect = new Rectangle(fokep.Location.X, fokep.Location.Y, fokep.Width, fokep.Height);
            fomenuRect = new Rectangle(fomenu.Location.X, fomenu.Location.Y, fomenu.Width, fomenu.Height);
            textBoxRolunkRect = new Rectangle(textBoxRolunk.Location.X, textBoxRolunk.Location.Y, textBoxRolunk.Width, textBoxRolunk.Height);
            fogado_szovegRect = new Rectangle(fogado_szoveg.Location.X, fogado_szoveg.Location.Y, fogado_szoveg.Width, fogado_szoveg.Height);
        }

        private void indulo_felulet_Resize(object sender, EventArgs e)
        {
            resizeChildren();
        }

        private void adminLabel_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kivalasztott = comboBox1.Text;
            //MessageBox.Show(kivalasztott);

            switch (kivalasztott)
            {
                case "Yoga":
                    fokep.Image = yoga;
                    break;
                case "Spinning":
                    fokep.Image = spinning;
                    break;
                case "Pilates":
                    fokep.Image = pilates;
                    break;
                default:
                    fokep.Image = altalanos;
                    break;
            }
        }
    }
}