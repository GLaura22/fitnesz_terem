using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnesz_terem.Database_Backend.Connection
{
    public class FitnessDbContext : DbContext
    {
        //EZ MINDENKINEK A SAJÁTJÁRA KELL ÁTÍRNIA.
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true";
        //egyszer elég


        public DbSet<Data> Datas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Personaltraining> Personaltraining { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TrainingClass> TrainingClasses { get; set; }
        public DbSet<FitnessUser> FitnessUsers { get; set; }
        public DbSet<UsersToClass> usersToClasses { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }    
}
