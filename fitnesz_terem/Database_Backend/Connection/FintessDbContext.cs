using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Connection
{
    public class FintessDbContext : DbContext
    {
        //EZ MINDENKINEK A SAJÁTJÁRA KELL ÁTÍRNIA.
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
        //egyszer elég


        public List<Data> Datas { get; set; }
        public List<Item> Items { get; set; }
        public List<Location> Locations { get; set; }
        public List<Order> Orders { get; set; }
        public List<Personaltraining> Personaltraining { get; set; }
        public List<Role> Roles { get; set; }
        public List<TrainingClass> TrainingClasses { get; set; }
        public List<User> Users { get; set; }
        public List<UsersToClass> usersToClasses { get; set; }


        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
