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
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT('Roles', RESEED, 0)");
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
                                    StartTime = new DateTime(2023, 4, 20, 9, 0, 0),
                                    EndTime = new DateTime(2023, 4, 20, 10, 0, 0),
                                    MaxPeople = 20,
                                    LocationID = 1,
                                    CoachID = 1
                                },
                                new TrainingClass
                                {
                                    ClassName = "Pilates",
                                    StartTime = new DateTime(2023, 4, 27, 10, 0, 0),
                                    EndTime = new DateTime(2023, 4, 27, 11, 30, 0),
                                    MaxPeople = 15,
                                    LocationID = 7,
                                    CoachID = 2
                                },
                                new TrainingClass
                                {
                                    ClassName = "Spinning",
                                    StartTime = new DateTime(2023, 4, 25, 12, 0, 0),
                                    EndTime = new DateTime(2023, 4, 25, 13, 0, 0),
                                    MaxPeople = 10,
                                    LocationID = 5,
                                    CoachID = 3
                                },
                                new TrainingClass
                                {
                                    ClassName = "Zumba",
                                    StartTime = new DateTime(2023, 4, 22, 18, 0, 0),
                                    EndTime = new DateTime(2023, 4, 22, 19, 0, 0),
                                    MaxPeople = 25,
                                    LocationID = 2,
                                    CoachID = 4
                                },
                                new TrainingClass
                                {
                                    ClassName = "Kickboxing",
                                    StartTime = new DateTime(2023, 4, 23, 11, 0, 0),
                                    EndTime = new DateTime(2023, 4, 23, 12, 0, 0),
                                    MaxPeople = 12,
                                    LocationID = 3,
                                    CoachID = 5
                                },
                                new TrainingClass
                                {
                                    ClassName = "CrossFit",
                                    StartTime = new DateTime(2023, 4, 28, 8, 0, 0),
                                    EndTime = new DateTime(2023, 4, 28, 9, 0, 0),
                                    MaxPeople = 18,
                                    LocationID = 6,
                                    CoachID = 6
                                },
                                new TrainingClass
                                {
                                    ClassName = "Barre",
                                    StartTime = new DateTime(2023, 4, 26, 17, 0, 0),
                                    EndTime = new DateTime(2023, 4, 26, 18, 0, 0),
                                    MaxPeople = 20,
                                    LocationID = 4,
                                    CoachID = 7
                                },
                                new TrainingClass
                                {
                                    ClassName = "HIIT",
                                    StartTime = new DateTime(2023, 4, 24, 16, 0, 0),
                                    EndTime = new DateTime(2023, 4, 24, 17, 0, 0),
                                    MaxPeople = 15,
                                    LocationID = 8,
                                    CoachID = 8
                                },
                                new TrainingClass
                                    {
                                        ClassName = "Yoga",
                                        StartTime = new DateTime(2023, 4, 14, 9, 0, 0),
                                        EndTime = new DateTime(2023, 4, 14, 10, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 1,
                                        CoachID = 1
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Pilates",
                                        StartTime = new DateTime(2023, 4, 15, 10, 0, 0),
                                        EndTime = new DateTime(2023, 4, 15, 11, 30, 0),
                                        MaxPeople = 15,
                                        LocationID = 7,
                                        CoachID = 2
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Spinning",
                                        StartTime = new DateTime(2023, 4, 16, 12, 0, 0),
                                        EndTime = new DateTime(2023, 4, 16, 13, 0, 0),
                                        MaxPeople = 10,
                                        LocationID = 5,
                                        CoachID = 3
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Zumba",
                                        StartTime = new DateTime(2023, 4, 17, 18, 0, 0),
                                        EndTime = new DateTime(2023, 4, 17, 19, 0, 0),
                                        MaxPeople = 25,
                                        LocationID = 2,
                                        CoachID = 4
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Kickboxing",
                                        StartTime = new DateTime(2023, 4, 18, 11, 0, 0),
                                        EndTime = new DateTime(2023, 4, 18, 12, 0, 0),
                                        MaxPeople = 12,
                                        LocationID = 3,
                                        CoachID = 5
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "CrossFit",
                                        StartTime = new DateTime(2023, 4, 19, 8, 0, 0),
                                        EndTime = new DateTime(2023, 4, 19, 9, 0, 0),
                                        MaxPeople = 18,
                                        LocationID = 6,
                                        CoachID = 6
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Barre",
                                        StartTime = new DateTime(2023, 4, 20, 17, 0, 0),
                                        EndTime = new DateTime(2023, 4, 20, 18, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 4,
                                        CoachID = 7
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "HIIT",
                                        StartTime = new DateTime(2023, 4, 21, 16, 0, 0),
                                        EndTime = new DateTime(2023, 4, 21, 17, 0, 0),
                                        MaxPeople = 15,
                                        LocationID = 8,
                                        CoachID = 8
                                    },new TrainingClass
                                    {
                                        ClassName = "Pilates",
                                        StartTime = new DateTime(2023, 4, 23, 11, 0, 0),
                                        EndTime = new DateTime(2023, 4, 23, 12, 0, 0),
                                        MaxPeople = 15,
                                        LocationID = 1,
                                        CoachID = 2
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Yoga",
                                        StartTime = new DateTime(2023, 4, 24, 14, 0, 0),
                                        EndTime = new DateTime(2023, 4, 24, 15, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 3,
                                        CoachID = 1
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Spinning",
                                        StartTime = new DateTime(2023, 4, 25, 13, 0, 0),
                                        EndTime = new DateTime(2023, 4, 25, 14, 0, 0),
                                        MaxPeople = 10,
                                        LocationID = 2,
                                        CoachID = 3
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "CrossFit",
                                        StartTime = new DateTime(2023, 4, 26, 12, 0, 0),
                                        EndTime = new DateTime(2023, 4, 26, 13, 0, 0),
                                        MaxPeople = 18,
                                        LocationID = 4,
                                        CoachID = 4
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Barre",
                                        StartTime = new DateTime(2023, 4, 27, 17, 0, 0),
                                        EndTime = new DateTime(2023, 4, 27, 18, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 6,
                                        CoachID = 5
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Yoga",
                                        StartTime = new DateTime(2023, 4, 28, 10, 0, 0),
                                        EndTime = new DateTime(2023, 4, 28, 11, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 1,
                                        CoachID = 1
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Pilates",
                                        StartTime = new DateTime(2023, 4, 29, 9, 0, 0),
                                        EndTime = new DateTime(2023, 4, 29, 10, 0, 0),
                                        MaxPeople = 15,
                                        LocationID = 7,
                                        CoachID = 2
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Spinning",
                                        StartTime = new DateTime(2023, 4, 30, 11, 0, 0),
                                        EndTime = new DateTime(2023, 4, 30, 12, 0, 0),
                                        MaxPeople = 10,
                                        LocationID = 5,
                                        CoachID = 3
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Zumba",
                                        StartTime = new DateTime(2023, 5, 1, 18, 30, 0),
                                        EndTime = new DateTime(2023, 5, 1, 19, 30, 0),
                                            MaxPeople = 25,
                                        LocationID = 3,
                                        CoachID = 6
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Boxing",
                                        StartTime = new DateTime(2023, 5, 2, 15, 0, 0),
                                        EndTime = new DateTime(2023, 5, 2, 16, 0, 0),
                                        MaxPeople = 12,
                                        LocationID = 1,
                                        CoachID = 7
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Yoga",
                                        StartTime = new DateTime(2023, 5, 3, 8, 0, 0),
                                        EndTime = new DateTime(2023, 5, 3, 9, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 4,
                                        CoachID = 1
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Pilates",
                                        StartTime = new DateTime(2023, 5, 4, 16, 0, 0),
                                        EndTime = new DateTime(2023, 5, 4, 17, 0, 0),
                                        MaxPeople = 15,
                                        LocationID = 2,
                                        CoachID = 2
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Spinning",
                                        StartTime = new DateTime(2023, 5, 5, 19, 0, 0),
                                        EndTime = new DateTime(2023, 5, 5, 20, 0, 0),
                                        MaxPeople = 10,
                                        LocationID = 5,
                                        CoachID = 3
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Bootcamp",
                                        StartTime = new DateTime(2023, 5, 6, 7, 0, 0),
                                        EndTime = new DateTime(2023, 5, 6, 8, 0, 0),
                                        MaxPeople = 25,
                                        LocationID = 6,
                                        CoachID = 4
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Yoga",
                                        StartTime = new DateTime(2023, 5, 7, 13, 0, 0),
                                        EndTime = new DateTime(2023, 5, 7, 14, 0, 0),
                                        MaxPeople = 20,
                                        LocationID = 1,
                                        CoachID = 1
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Pilates",
                                        StartTime = new DateTime(2023, 5, 8, 10, 0, 0),
                                        EndTime = new DateTime(2023, 5, 8, 11, 0, 0),
                                        MaxPeople = 15,
                                        LocationID = 7,
                                        CoachID = 2
                                    },
                                    new TrainingClass
                                    {
                                        ClassName = "Spinning",
                                        StartTime = new DateTime(2023, 5, 9, 17, 0, 0),
                                        EndTime = new DateTime(2023, 5, 9, 18, 0, 0),
                                        MaxPeople = 10,
                                        LocationID = 5,
                                        CoachID = 3
                                    }


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
                                Money = 100,
                                Lease = -1
                            },
                            new Data
                            {
                                UserId = 2,
                                Name = "Jane Doe",
                                Password = "password",
                                AccountNumber = 7654321,
                                Money = 50,
                                Lease = -1

                            },
                            new Data
                            {
                                 UserId = 3,
                                Name = "Alice Cooper",
                                Password = "password",
                                AccountNumber = 24681012,
                                Money = 200,
                                Lease = -1
                            },
                            new Data
                            {
                                UserId = 4,
                                Name = "Bob Lee",
                                Password = "password",
                                AccountNumber = 369518,
                                Money = 75,
                                Lease = -1
                            },
                            new Data
                            {

                                 UserId = 5,
                                Name = "David Kim",
                                Password = "password",
                                AccountNumber = 1123321,
                                Money = 150,
                                Lease = -1
                            },
                            new Data
                            {   
                                UserId = 6,
                                Name = "Emily Chen",
                                Password = "password",
                                AccountNumber = 1416535,
                                Money = 125,
                                Lease = -1
                            },
                            new Data
                            {

                                 UserId = 7,
                                Name = "Frank Wang",
                                Password = "password",
                                AccountNumber = 1732050808,
                                Money = 300,
                                Lease = -1
                            },
                            new Data
                            {
                                 UserId = 8,
                                Name = "Grace Lee",
                                Password = "password",
                                AccountNumber = 11235813,
                                Money = 25,
                                Lease = -1
                            },
                            new Data
                            {
                                UserId = 9,
                                Name = "Henry Liu",
                                Password = "password",
                                AccountNumber = 31592653,
                                Money = 175,
                                Lease = -1
                            },
                            new Data
                            {
                                UserId = 10,
                                Name = "Isabella Wu",
                                Password = "password",
                                AccountNumber = 2711828,
                                Money = 250,
                                Lease = -1
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
