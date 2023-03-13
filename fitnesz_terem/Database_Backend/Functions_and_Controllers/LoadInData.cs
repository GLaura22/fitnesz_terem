using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fitnesz_terem.Database_Backend.Functions_and_Controllers
{
    public class LoadInData
    {
        public void DataLoad()
        {

            Task.Run(() =>
            {
                // szerepkörök feltöltése
                using (var context = new FitnessDbContext())
                {
                    // Check if the Roles DbSet is empty
                    if (!context.Roles.Any())
                    {
                        string[] labels = { "Adminisztrátor", "Személyi Edző", "Tag"};

                        // Create a new Role object for each label and add it to the Roles table
                        foreach (string label in labels)
                        {
                            var newRole = new Role
                            {
                                Label = label
                            };

                            context.Roles.Add(newRole);
                        }
                        // Save changes to the database
                        context.SaveChanges();
                    }
                }
                //eladó termékek feltöltése.
                using (var context = new FitnessDbContext())
                {
                    // Check if the Roles DbSet is empty
                    if (!context.Items.Any())
                    {
                            // Create an array of 10 new Item objects with fictional data
                        var newItems = new Item[]
                        {
                            new Item
                            {
                                Name = "Edzőkesztyű",
                                Price = 1500,
                                NumberInStock = 10
                            },
                            new Item
                            {
                                Name = "Futópad",
                                Price = 1200,
                                NumberInStock = 8
                            },
                            new Item
                            {
                                Name = "Tömegnövelő fehérje",
                                Price = 500,
                                NumberInStock = 15
                            },
                            new Item
                            {
                                Name = "Súlyzókészlet",
                                Price = 300,
                                NumberInStock = 20
                            },
                            new Item
                            {
                                Name = "Kettlebell Set",
                                Price = 250,
                                NumberInStock = 12
                            },
                            new Item
                            {
                                Name = "Protein szelet",
                                Price = 20,
                                NumberInStock = 30
                            },
                            new Item
                            {
                                Name = "Súlyemelő öv",
                                Price = 50,
                                NumberInStock = 25
                            },
                            new Item
                            {
                                Name = "Gumi labda",
                                Price = 25,
                                NumberInStock = 20
                            }
                     };

                        // Add the new Item objects to the Items table
                        context.Items.AddRange(newItems);

                        // Save changes to the database
                        context.SaveChanges();
                    }
                }
                //termek feltöltése
                using (var context = new FitnessDbContext())
                {
                    if (!context.Locations.Any())
                    {
                        var newLocations = new List<Location>
                        {
                            new Location
                            {
                                LocationName = "Nagyterem 1",
                                Level = 1
                            },
                            new Location
                            {
                                LocationName = "Nagyterem 2",
                                Level = 2
                            },
                            new Location
                            {
                                LocationName = "Kardio terem",
                                Level = 1
                            },
                            new Location
                            {
                                LocationName = "Kettlebell terem",
                                Level = 3
                            },
                            new Location
                            {
                                LocationName = "Spinning terem",
                                Level = 1
                            },
                            new Location
                            {
                                LocationName = "Kick-box terem",
                                Level = 2
                            },
                            new Location
                            {
                                LocationName = "Pilates stúdió",
                                Level = 3
                            },
                            new Location
                            {
                                LocationName = "TRX terem",
                                Level = 2
                            }
                        };

                        context.Locations.AddRange(newLocations);
                        context.SaveChanges();
                    }
                }
                //edzés órák feltöltése
                using (var context = new FitnessDbContext())
                {
                    if (!context.TrainingClasses.Any())
                    {
                        var newTrainingClasses = new List<TrainingClass>
                            {
                                new TrainingClass
                                {
                                    ClassName = "Yoga",
                                    StartTime = new DateTime(2023, 3, 10, 9, 0, 0),
                                    EndTime = new DateTime(2023, 3, 10, 10, 0, 0),
                                    MaxPeople = 20,
                                    LocationID = 1,
                                    CoachID = 1
                                },
                                new TrainingClass
                                {
                                    ClassName = "Pilates",
                                    StartTime = new DateTime(2023, 3, 11, 10, 0, 0),
                                    EndTime = new DateTime(2023, 3, 11, 11, 0, 0),
                                    MaxPeople = 15,
                                    LocationID = 7,
                                    CoachID = 2
                                },
                                new TrainingClass
                                {
                                    ClassName = "Spinning",
                                    StartTime = new DateTime(2023, 3, 12, 12, 0, 0),
                                    EndTime = new DateTime(2023, 3, 12, 13, 0, 0),
                                    MaxPeople = 10,
                                    LocationID = 5,
                                    CoachID = 3
                                },
                                // add more training classes here
                            };

                        context.TrainingClasses.AddRange(newTrainingClasses);
                        context.SaveChanges();
                    }
                }
                // users
                using (var context = new FitnessDbContext())
                { 
                    if (!context.Datas.Any())
                    {
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Datas', RESEED, 0)");
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('FitnessUsers', RESEED, 0)");
                        var newData = new List<Data>
                        {
                            new Data
                            {
                                UserId = 1,
                                Name = "John Smith",
                                Password = "password",
                                AccountNumber = 123459,
                                Money = 100
                            },
                            new Data
                            {
                                 UserId = 2,
                                Name = "Jane Doe",
                                Password = "password",
                                AccountNumber = 7654321,
                                Money = 50
                            },
                            new Data
                            {
                                 UserId = 3,
                                Name = "Alice Cooper",
                                Password = "password",
                                AccountNumber = 24681012,
                                Money = 200
                            },
                            new Data
                            {
                                UserId = 4,
                                Name = "Bob Lee",
                                Password = "password",
                                AccountNumber = 369518,
                                Money = 75
                            },
                            new Data
                            {

                                 UserId = 5,
                                Name = "David Kim",
                                Password = "password",
                                AccountNumber = 1123321,
                                Money = 150
                            },
                            new Data
                            {   
                                UserId = 6,
                                Name = "Emily Chen",
                                Password = "password",
                                AccountNumber = 1416535,
                                Money = 125
                            },
                            new Data
                            {

                                 UserId = 7,
                                Name = "Frank Wang",
                                Password = "password",
                                AccountNumber = 1732050808,
                                Money = 300
                            },
                            new Data
                            {
                                 UserId = 8,
                                Name = "Grace Lee",
                                Password = "password",
                                AccountNumber = 11235813,
                                Money = 25
                            },
                            new Data
                            {
                                UserId = 9,
                                Name = "Henry Liu",
                                Password = "password",
                                AccountNumber = 31592653,
                                Money = 175
                            },
                            new Data
                            {
                                 UserId = 10,
                                Name = "Isabella Wu",
                                Password = "password",
                                AccountNumber = 2711828,
                                Money = 250
                            }
                        };

                        context.Datas.AddRange(newData);
                        context.SaveChanges();
                    }

                    if (!context.FitnessUsers.Any())
                    {
                        var newUsers = new List<FitnessUser>
                        {
                            new FitnessUser
                            {
                                DataId = 1,
                                Role = 1
                            },
                            new FitnessUser
                            {
                                DataId = 2,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 3,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 4,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 5,
                                Role = 2
                            },
                            new FitnessUser
                            {
                                DataId = 6,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 7,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 8,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 9,
                                Role = 3
                            },
                            new FitnessUser
                            {
                                DataId = 10,
                                Role = 2
                            }
                        };
                        
                        context.FitnessUsers.AddRange(newUsers);
                        context.SaveChanges();
                    }
                }


            });
        }
    }
}
