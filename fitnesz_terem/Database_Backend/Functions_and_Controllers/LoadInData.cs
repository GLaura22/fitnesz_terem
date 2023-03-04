using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fitnesz_terem.Database_Backend.Functions_and_Controllers
{
    public class LoadInData
    {
        public void DataLoad()
        {

            Task.Run(() =>
            {
                using (var context = new FitnessDbContext())
                {
                    // Check if the Roles DbSet is empty
                    if (!context.Roles.Any())
                    {
                        string[] labels = { "Administrator", "Private Coach", "Trainee", "Guest" };

                        // Create a new Role object for each label and add it to the Roles table
                        foreach (string label in labels)
                        {
                            var newRole = new Role
                            {
                                Label = label
                            };

                            context.Roles.Add(newRole);
                        }
                        // Save changes to the database
                        context.SaveChanges();
                    }
                }

























            });






        }
    }
}
