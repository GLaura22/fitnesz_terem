﻿using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public Data getDataFromID(int userID)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                /* Get fitness user ID by the given username & password. */
                var data = context.Datas
                    .Single(row => row.UserId == userID);

                return data;
            }
            catch (Exception)
            {
                return new Data
                {
                    Id = 0,
                    UserId = 0,
                    Name = "",
                    Password = "",
                    AccountNumber = 0,
                    Money = 0,
                    Lease = 0
                };
            }
        }

        public List<TrainingClass> GetTrainingClassesesByID(int userID) {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var trainingClasses = context.TrainingClasses
                    .Where(row => row.CoachID == userID)
                    .ToList();

                return trainingClasses;
            }
            catch (Exception)
            {
                return new List<TrainingClass> {};
            }
        }
        public List<PersonalTrainingViewModel> GetPersonalTrainingsByID(int userID)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                List<PersonalTrainingViewModel> personalTraining = context.Personaltraining
                    .Join(context.Datas, d => d.SportoloId, u => u.UserId, (d, u) => new PersonalTrainingViewModel
                    {
                        TrainingID = d.TrainingID,
                        UserId = u.UserId,
                        Name = u.Name,
                        CoachID = d.CoachID
                    })
                    .Where(d => d.CoachID == userID)
                    .ToList();

                return personalTraining;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return new List<PersonalTrainingViewModel> { };
            }
        }
        public void payWithMoney(int userID, int number = 4000)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var money = context.Datas.First(a => a.UserId == userID);
                money.Money -= number;

                context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void payWithLease(int userID, int number = 1)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var lease = context.Datas.First(a => a.UserId == userID);
                lease.Lease -= number;

                context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        public bool hasLease(int userID)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var data = context.Datas.First(a => a.UserId == userID);

                if (data.Lease <= -1)
                {
                    throw new Exception("Nem rendelkezik bérlettel!");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool hasEnoughMoney(int userID, int money)
        {
            try
            {
                /* SQL Connection. */
                var context = new FitnessDbContext();

                var data = context.Datas.First(a => a.UserId == userID);

                if (data.Money < money)
                {
                    throw new Exception("Nem rendelkezik elegendő pénzzel!");
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public double AverageReview(int coachID)
        {
            using (var context = new FitnessDbContext())
            {
                var reviews = context.Reviews.Where(r => r.CoachID == coachID).ToList();

                if (reviews.Any())
                {
                    double avg;
                    int sum = 0;
                    //int count = 0;

                    foreach (var review in reviews)
                    {
                        sum += review.ReviewStars;
                        //count++;
                    }

                    avg = sum / reviews.Count;

                    return avg;
                }

                else
                {
                    return -1;
                }

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
    public class PersonalTrainingViewModel
    {
        public int TrainingID { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int CoachID { get; set; }
    }
    public class TrainingClassesViewModel
    {
        public int ClassID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MaxPeople { get; set; }
        public int LocationID { get; set; }
        public string ClassName { get; set; }
        public int CoachID { get; set; }
    }


}
