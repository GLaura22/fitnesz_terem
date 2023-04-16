﻿using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnesz_terem
{
    public partial class Tag : Form
    {
        public Tag()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            keresesPanel.Visible = false;
            szemelyi_edzo_keresesPanel.Visible = false;
            ertekelesPanel2.Visible = false;
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            SelectedDateLabel.Text = $"{monthCalendar1.TodayDate}";

            using ( var context = new FitnessDbContext())
            { 
                var classNames = context.TrainingClasses
                                  .Select(c => c.ClassName)
                                  .Distinct()
                                  .ToList();
                // Add the class names to the list box
                Classes_Listbox.Items.AddRange(classNames.ToArray());
            }

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
                foreach(var c in coachNames ) 
                {
                    nevek.Add(c.CoachName);
                }
                Coaches_List.Items.AddRange(nevek.ToArray());
            }


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            using (var context = new FitnessDbContext())
            {
                // First, retrieve the list of all classes that the user is registered for:
                List<UsersToClass> userClasses = context.usersToClasses
                    .Where(utc => utc.UserID == 2)
                    .ToList();

                // Next, retrieve the details of each class that falls on the selected date:
                List<string> activitiesForUser = new List<string>();


                foreach (UsersToClass userClass in userClasses)
                {
                    var trainingClass = (from tc in context.TrainingClasses
                                         join l in context.Locations on tc.LocationID equals l.LocationID
                                         where tc.ClassID == userClass.ClassID && tc.StartTime.Date == monthCalendar1.SelectionStart.Date
                                         select new
                                         {
                                             tc.ClassName,
                                             tc.StartTime,
                                             tc.EndTime,
                                             LocationName = l.LocationName,
                                             Level = l.Level,
                                             tc.CoachID
                                         }).FirstOrDefault();

                    if (trainingClass != null)
                    {
                        string activityText = $"{trainingClass.ClassName} ({trainingClass.StartTime.ToShortTimeString()} - {trainingClass.EndTime.ToShortTimeString()}) @ {trainingClass.LocationName} | {trainingClass.Level}. emeleten";
                        activitiesForUser.Add(activityText);
                    }
                }



                // Remove all labels with the prefix "activityLabel_"
                for (int i = this.Controls.Count - 1; i >= 0; i--)
                {
                    Control c = this.Controls[i];
                    if (c is Label && c.Name.StartsWith("activityLabel_"))
                    {
                        this.Controls.Remove(c);
                    }
                }


                // Display the list of activities in labels
                int x = 20;
                int y = 20;
                int labelHeight = 30;
                foreach (string activity in activitiesForUser)
                {
                    Label activityLabel = new Label();
                    activityLabel.Name = "activityLabel_" + activity;
                    activityLabel.Text = activity;
                    activityLabel.AutoSize = true;
                    activityLabel.Location = new Point(x, y);
                    activityLabel.Height = labelHeight;
                    this.Controls.Add(activityLabel);

                    y += labelHeight + 5;
                }
            }

            SelectedDateLabel.Text = $"{e.Start.ToShortDateString()}";
        }

        private void Classes_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected class name
            string selectedClassName = Classes_Listbox.SelectedItem.ToString();

            using (var context = new FitnessDbContext())
            {
                // Retrieve the list of start times for the selected class
                var startTimes = context.TrainingClasses
                                      .Where(c => c.ClassName == selectedClassName)
                                      .Select(c => c.StartTime)
                                      .ToList();

                // Add the start times to the Times_Listbox control
                Times_Listbox.Items.Clear();
                foreach (var startTime in startTimes)
                {
                    Times_Listbox.Items.Add(startTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }

            }
        }

        private void Times_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var context = new FitnessDbContext())
            {
                // Retrieve the selected class name and start time
                string selectedClassName = Classes_Listbox.SelectedItem.ToString();

                DateTime selectedStartTime = DateTime.Parse(Times_Listbox.SelectedItem.ToString());

                var trainingClass = context.TrainingClasses.SingleOrDefault(c => c.ClassName == selectedClassName && c.StartTime == selectedStartTime);

                int coachId = context.TrainingClasses.Where(tc => tc.ClassName == selectedClassName && tc.StartTime == selectedStartTime).Select(tc => tc.CoachID).FirstOrDefault();

                int dataId = context.FitnessUsers.Where(fu => fu.UserID == coachId).Select(fu => fu.DataId).FirstOrDefault();

                string coachName = context.Datas.Where(d => d.Id == dataId).Select(d => d.Name).FirstOrDefault();




                // Set the text of the Label controls in the Details_GroupBox to display the attributes of the selected training class
                if (trainingClass != null)
                {
                    //ClassID_Label.Text = $"Class ID: {trainingClass.ClassID}";
                    ClassName_Label.Text = $"Ora tipusa: {trainingClass.ClassName}";
                    StartTime_Label.Text = $"Kezdes: {trainingClass.StartTime.ToString("yyyy-MM-dd HH:mm:ss")}";
                    EndTime_Label.Text = $"Befejezes: {trainingClass.EndTime.ToString("yyyy-MM-dd HH:mm:ss")}";
                   
                    //LocationID_Label.Text = $"Location ID: {trainingClass.LocationID}";
                    

                    if (coachName != null)
                    {
                        CoachName_Label.Text = $"Edzo neve: {coachName}";
                    }
                    else
                    {
                        CoachName_Label.Text = "";
                    }

                    // Count the number of users who joined the class
                    var numUsersJoined = context.usersToClasses.Count(utc => utc.ClassID == trainingClass.ClassID);

                    JoinedAndMax_Label.Text = $"Jelenleg {numUsersJoined} fo van a(z) {trainingClass.MaxPeople}-bol";
                }
                else
                {
                    //ClassID_Label.Text = "";
                    ClassName_Label.Text = "";
                    StartTime_Label.Text = "";
                    EndTime_Label.Text = "";
                    //LocationID_Label.Text = "";
                    CoachName_Label.Text = "";
                    JoinedAndMax_Label.Text = "";
                }
            }
        }

        private void csoportfoglalkozásraJelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keresesPanel.Visible = true;
            szemelyi_edzo_keresesPanel.Visible = false;
            ertekelesPanel2.Visible = false;
        }

        private void személyiEdzőhözJelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            szemelyi_edzo_keresesPanel.Visible = true;
            keresesPanel.Visible = false;
            ertekelesPanel2.Visible = false;
        }

        private void értékelésKüldéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ertekelesPanel2.Visible = true;
            keresesPanel.Visible = false;
            szemelyi_edzo_keresesPanel.Visible = false;
        }

        private void edzesre_Jelentkezes_Button_Click(object sender, EventArgs e)
        {
            if (Classes_Listbox.SelectedIndex != null && Times_Listbox.SelectedIndex != null)
            {
                using (var context = new FitnessDbContext())
                {
                    string classname = Classes_Listbox.SelectedItem.ToString();
                    var starttime = DateTime.Parse(Times_Listbox.SelectedItem.ToString());

                    var user = 3; // retrieve the currently logged-in user ID (in this example, it's hardcoded as 3)
                    var selectedClass = context.TrainingClasses.FirstOrDefault(c => c.ClassName == Classes_Listbox.SelectedItem.ToString() && c.StartTime == DateTime.Parse(Times_Listbox.SelectedItem.ToString())); // retrieve the selected class

                    // Check if the user and class ID already exist in the UsersToClass table
                    var existingRecord = context.usersToClasses.FirstOrDefault(utc => utc.UserID == user && utc.ClassID == selectedClass.ClassID);

                    if (existingRecord == null)
                    {
                        // If the record doesn't exist, create a new UsersToClass object and add it to the database
                        var userToClass = new UsersToClass
                        {
                            UserID = user,
                            ClassID = selectedClass.ClassID
                        };

                        context.usersToClasses.Add(userToClass);
                        context.SaveChanges();

                        // Display a success message
                        MessageBox.Show("You have successfully signed up for the class!");
                    }
                    else
                    {
                        // If the record already exists, display an error message
                        MessageBox.Show("You have already signed up for this class.");
                    }
                }
            }
        }

    }
}
