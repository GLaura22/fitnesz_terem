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
    public class ReviewController
    {
        internal List<Review> GetReviews()
        {
            using (var context = new FitnessDbContext())
            {
                var reviews = context.Reviews.ToList();
                return reviews;
            }
        }

    }
}
