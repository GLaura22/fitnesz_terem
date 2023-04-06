using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Tag : Form
    {
        public Tag()
        {
            InitializeComponent();
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

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
        }


    }
}
