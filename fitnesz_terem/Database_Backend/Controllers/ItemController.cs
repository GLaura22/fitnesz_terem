using fitnesz_terem.Database_Backend.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace fitnesz_terem.Database_Backend.Controllers
{
    public class ItemController
    {
        internal List<Modells_Tables.Item> GetItems()
        {
            using (var context = new FitnessDbContext())
            {
                var items = context.Items.ToList();
                return items;
            }
        }
    }
}
