using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;

namespace fitnesz_terem.Database_Backend.Controllers
{
    public class UserController
    {
        public int InsertIntoFitnessUser(FitnessUser fitnessUser)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                /* Insert data into Database. */
                context.FitnessUsers.Add(fitnessUser);
                context.SaveChanges();

                /* Get last inserted ID. */
                var id = context.FitnessUsers.OrderBy(row => row.UserID).Last();

                /* Return the previously saved ID. */
                return id.UserID;
            }
            catch (Exception exception)
            {
                /* On error. */
                MessageBox.Show("Failed to register! (" + exception.Message + ")");
                return 0; // Return 0 to easily check if there is a problem or not.
            }
        }

        public bool InsertIntoDatas(Data data)
        {
            try
            {
                var context = new FitnessDbContext();

                context.Datas.Add(data);
                context.SaveChanges();

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to register! (" + exception.Message + ")");
                return false;
            }
        }
        public List<Role> GetRoles()    
        {
            using (var context = new FitnessDbContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}
