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

        public List<ItemViewModel> GetItemViewModel()
        {
            try
            {
                using (var context = new FitnessDbContext())
                {
                    List<ItemViewModel> products = context.Items
                                    .Select(x => new ItemViewModel
                                    {
                                        ItemId = x.itemID,
                                        ItemName = x.Name,
                                        Price= x.Price,
                                        NumberInStock= x.NumberInStock
                                    }).ToList();

                    return products;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

                return new List<ItemViewModel>();
            }
        }
    }

    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int NumberInStock { get; set; }
    }
}
