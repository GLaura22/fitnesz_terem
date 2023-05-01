using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
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

        public void vasarlas(int userID, int itemID)
        {
            try
            {
                var context = new FitnessDbContext();

                //==============================
                // Adatok lekérése
                //==============================

                /* A megfelelő felhasználó megkeresése. */
                var user = context.Datas
                    .First(row => row.UserId == userID);

                /* A megfelelő termék megkeresése. */
                var item = context.Items
                    .First(row => row.itemID == itemID);

                //==============================
                // Validáció
                //==============================

                /* A felhasználó létezésének vizsgálata. */
                if (user == null)
                    throw new Exception("A felhasználó nem található!");

                /* A termék létezésének vizsgálata. */
                if (item == null)
                    throw new Exception("A termék nem található!");

                /* Van-e raktáron az adott termék. */
                if (item.NumberInStock <= 0)
                    throw new Exception("A termék nincs raktáron!");

                /* Megvizsgálni, hogy van-e elegendő pénz a felhasználó számláján. */
                if (user.Money < item.Price)
                    throw new Exception($"Nincs elegendő egyenleg a számlán! ({item.Price} Ft)");

                //==============================
                // Vásárlás végrehajtása
                //==============================

                DateTime orderDate = DateTime.Now;

                /* Levonás a raktárból. */
                item.NumberInStock--;

                /* Felhasználó egyenlegéből levonni a termék árát. */
                user.Money -= item.Price;

                /* Felvenni a rendelést. */
                context.Orders.Add(new Order
                {
                    ItemID = user.UserId,
                    userID = item.itemID,
                    OrderDate = orderDate
                });

                /* Vásárlás végrehajtása. */
                context.SaveChanges();

                MessageBox.Show("A vásárlás sikeresen megtörtént!");
                
                MessageBox.Show($"Név: {user.Name}\nTermék: {item.Name}\nÁr: {item.Price}\nIdő: {orderDate}");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
