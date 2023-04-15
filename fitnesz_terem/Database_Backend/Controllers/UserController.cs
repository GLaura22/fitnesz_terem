using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using System;

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
            catch (Exception)
            {
                /* On error. */
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
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveFromFitnessUsers(int id)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                /* Insert data into Database. 
                FitnessUser felh = new FitnessUser() { UserID = -1 };
                felh = context.FitnessUsers.Find(UserId);
                context.FitnessUsers.Remove(felh);
                context.SaveChanges();  */

                var user = context.FitnessUsers.First(c => c.UserID == id);

                if (user != null)
                {
                    context.Remove(user);
                }
                else if (user == null)
                {
                    return false;
                }

                context.SaveChanges();


                return true;
            }
            catch(Exception) 
            {
                return false;
            }
        }

        public bool RemoveFromDatas(int id)
        {
            try
            {
                var context = new FitnessDbContext();
                var user = context.Datas.First(c => c.UserId == id);
                if (user != null)
                {
                    context.Remove(user);
                }
                else if (user == null)
                { 
                    return false; 
                }
                
                context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
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

        public FitnessUser Login(string username, string password)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                /* Get fitness user ID by the given username & password. */
                var data = context.Datas
                    .Single(row => row.Name == username && row.Password == password);

                /* Get fitness user by previously fetched ID. */
                var fitnessUser = context.FitnessUsers
                    .Single(row => row.UserID == data.UserId);

                return fitnessUser;
            }
            catch (Exception)
            {
                return new FitnessUser { UserID = 0, DataId = 0, Role = 0 };
            }
        }

        public List<UserViewModel> GetUsers()
        {
            using (var context = new FitnessDbContext())
            {
                List<UserViewModel> users = context.Datas.Join(context.FitnessUsers,d => d.UserId,u => u.UserID,(d, u) => new UserViewModel
                {
                    UserId = d.UserId,
                    Name = d.Name,
                    Password = d.Password,
                    AccountNumber = d.AccountNumber,
                    Money = d.Money,
                    Role = u.Role
                }).ToList();


                return users;
            }
        }
    }

    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int AccountNumber { get; set; }
        public int Money { get; set; }
        public int Role { get; set; }
    }


}
