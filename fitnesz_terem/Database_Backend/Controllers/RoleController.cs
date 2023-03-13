using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace fitnesz_terem.Database_Backend.Controllers
{
    public class RoleController
    {
        public static string GetRoleByID(int roleID)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var role = context.Roles
                    .Single(row => row.RoleID == roleID);

                /* Return the previously saved ID. */
                return role.Label;
            }
            catch (Exception)
            {
                /* On error. */
                return "";
            }
        }
    }
}
