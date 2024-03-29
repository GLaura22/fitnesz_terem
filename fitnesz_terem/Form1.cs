﻿using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Controllers;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int labelHeight = 30;

        Bitmap yoga = Properties.Resources.yoga;
        Bitmap spinning = Properties.Resources.spinning;
        Bitmap altalanos = Properties.Resources.gym_hatter;
        Bitmap pilates = Properties.Resources.pilates;
        Bitmap zumba = Properties.Resources.zumba;
        Bitmap barre = Properties.Resources.barre;
        Bitmap bootcamp = Properties.Resources.bootcamp;
        Bitmap boxing = Properties.Resources.boxing;
        Bitmap crossfit = Properties.Resources.crossfit;
        Bitmap hiit = Properties.Resources.hiit;
        Bitmap kickboxing = Properties.Resources.kickboxing;


        public indulo_felulet()
        {
            InitializeComponent();
            fitnessUser = new FitnessUser { UserID = 0, DataId = 0, Role = 0 };
            textBoxRolunk.Visible = false;
            fogado_szoveg.BorderStyle = BorderStyle.None;
            textBoxRolunk.BorderStyle = BorderStyle.None;
            comboBox1.Visible = false;
            szolgLabel.Visible = false;
            fokep.Image = altalanos;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            tajekoztatoLabel.Visible = false;
            edzok_felsorolas.Visible = false;
            szemelyiEdzoaArLabel.Visible = false;
            csoportosEdzesArLabel.Visible = false;
            label1.Visible = false;
            WebshopListView.Visible = false;
        }

        private void formenu1_Click(object sender, EventArgs e)
        {
            fokep.Image = altalanos;
            szolgLabel.Visible = false;
            textBoxRolunk.Visible = true;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = false;
            tajekoztatoLabel.Visible = false;
            edzok_felsorolas.Visible = false;
            szemelyiEdzoaArLabel.Visible = false;
            csoportosEdzesArLabel.Visible = false;
            label1.Visible = false;
            WebshopListView.Visible = false;
        }

        private void foszmenu2_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = false;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = true;
            szolgLabel.Visible = true;
            tajekoztatoLabel.Visible = false;
            edzok_felsorolas.Visible = false;
            szemelyiEdzoaArLabel.Visible = false;
            csoportosEdzesArLabel.Visible = true;
            label1.Visible = false;
            WebshopListView.Visible = false;
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
                // Get a list of all unique class names from the training classes
                var classes = context.TrainingClasses
                  .GroupBy(tc => tc.ClassName)
                  .Select(g => g.First())
                  .ToList();



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
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ClassName";


            }

        }

        private void bejiregi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(f2.UserId().UserID.ToString());
            fitnessUser.UserID = f2.UserId().UserID;
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
                case "Barre":
                    fokep.Image = barre;
                    break;
                case "Bootcamp":
                    fokep.Image = bootcamp;
                    break;
                case "Boxing":
                    fokep.Image = boxing;
                    break;
                case "CrossFit":
                    fokep.Image = crossfit;
                    break;
                case "HIIT":
                    fokep.Image = hiit;
                    break;
                case "Kickboxing":
                    fokep.Image = kickboxing;
                    break;
                case "Zumba":
                    fokep.Image = zumba;
                    break;
                default:
                    fokep.Image = altalanos;
                    break;
            }
        }

        private void foemenu3_Click(object sender, EventArgs e)
        {
            textBoxRolunk.Visible = false;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = false;
            szolgLabel.Visible = false;
            fokep.Visible = false;
            tajekoztatoLabel.Visible = true;
            edzok_felsorolas.Visible = true;
            szemelyiEdzoaArLabel.Visible = true;
            csoportosEdzesArLabel.Visible = false;
            label1.Visible = false;
            WebshopListView.Visible = false;

            edzok_felsorolas.Items.Clear();

            using (var context = new FitnessDbContext())
            {


                var coachNames = context.Datas.Join(
                                        context.FitnessUsers,
                                        data => data.UserId,
                                        fitness => fitness.UserID,
                                        (_data, _fitness) => new
                                        {
                                            UserId = _data.UserId,
                                            CoachName = _data.Name,
                                            Role = _fitness.Role
                                        })
                                        .Where(c => c.Role == 2)
                                        .ToList();

                // Add the names to the list box

                List<string> nevek = new List<string>();
                foreach (var c in coachNames)
                {
                    nevek.Add(c.CoachName);
                }
                edzok_felsorolas.Items.AddRange(nevek.ToArray());
            }
        }

        private void edzok_felsorolas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCoachName = edzok_felsorolas.SelectedItem.ToString();

            using (var context = new FitnessDbContext())
            {
                // Get the ID of the selected coach based on their name
                int selectedCoachId = context.Datas
                    .Where(d => d.Name == selectedCoachName)
                    .Select(d => d.UserId)
                    .FirstOrDefault();

                DateTime today = DateTime.Today;

                // Get all TrainingClasses entities with the same CoachID as the selected coach's UserId
                List<TrainingClass> coachClasses = context.TrainingClasses
                    .Where(c => c.CoachID == selectedCoachId && c.StartTime.Date >= today)
                    .OrderBy(c => c.EndTime)
                    .ToList();

                // Sort the classes by start time
                coachClasses = coachClasses.OrderBy(c => c.StartTime).ToList();

                // Remove all labels with the prefix "classLabel_"
                for (int i = this.Controls.Count - 1; i >= 0; i--)
                {
                    Control c = this.Controls[i];
                    if (c is Label && c.Name.StartsWith("classLabel_") || c.Name.StartsWith("myLabel"))
                    {
                        this.Controls.Remove(c);
                    }
                }

                // Create a new Label AVG

                
                var tempUC = new UserController();

                var ertekeles = tempUC.AverageReview(selectedCoachId);

                
                    Label myLabel = new Label();

                    myLabel.Name = "myLabel";
                    myLabel.Font = new Font("Ariel", 30);
                    myLabel.BackColor = Color.Transparent;

                if (ertekeles > 0)
                {
                    for (int i = 0; i < ertekeles; i++)
                    {
                        myLabel.Text += "⭐";
                    }
                }
                else
                {
                    myLabel.Font = new Font("Ariel", 20);
                    myLabel.Text = "Nincs értékelése";

                }

                    //myLabel.Text = "értékelése: " + ertekeles;
                    myLabel.Location = new Point(500, 230);
                   
                    //myLabel.Height = labelHeight;
                    myLabel.AutoSize = true;

                    // Add the label to the form's controls collection

                    this.Controls.Add(myLabel);
                
                
                // Display the list of classes in labels
                int x = 800;
                int y = 250;
                
                foreach (var trainingClass in coachClasses)
                {
                    Label classLabel = new Label();
                    classLabel.Name = "classLabel_" + trainingClass.ClassName;
                    classLabel.Text = $"{trainingClass.ClassName} | {trainingClass.StartTime.ToString()} - {trainingClass.EndTime.ToShortTimeString()}";
                    classLabel.AutoSize = true;
                    classLabel.Location = new Point(x, y);
                    classLabel.Height = labelHeight;
                    this.Controls.Add(classLabel);

                    y += labelHeight + 5;
                }
            }
        }

        private void fowmenu4_Click(object sender, EventArgs e)
        {
            /*
            projektListazasPanel.Visible = true;

            ProjektController projektController = new();
            List<ProjektViewModel> projektLista = projektController.ProjektListaLekerese();

            projektekListView.Items.Clear();

            foreach (var projekt in projektLista)
            {
                ListViewItem item = new ListViewItem();

                item.Text = projekt.ProjektID.ToString();
                item.SubItems.Add(projekt.Leiras);
                item.SubItems.Add(projekt.Helyszin);
                item.SubItems.Add(projekt.MegrendeloNev);
                item.SubItems.Add(projekt.MegrendeloCim);
                item.SubItems.Add(projekt.Statusz);

                projektekListView.Items.Add(item);
            }*/

            textBoxRolunk.Visible = false;
            fogado_szoveg.Visible = false;
            comboBox1.Visible = false;
            szolgLabel.Visible = false;
            fokep.Visible = false;
            tajekoztatoLabel.Visible = false;
            edzok_felsorolas.Visible = false;
            szemelyiEdzoaArLabel.Visible = false;
            csoportosEdzesArLabel.Visible = false;
            label1.Visible = true;
            WebshopListView.Visible = true;

            ItemController itemController = new();
            List<ItemViewModel> products = itemController.GetItemViewModel();

            // hogy ne adja tobbszor hozza az elemeket
            WebshopListView.Items.Clear();

            foreach (var p in products)
            {
                // listaelem letrehozasa
                ListViewItem item = new ListViewItem();

                // elso oszlopba nevek feltoltese
                item.Text = p.ItemName;
                item.SubItems.Add(p.Price.ToString() + " Ft");

                // listahoz adas
                WebshopListView.Items.Add(item);
            }
        }
    }
}