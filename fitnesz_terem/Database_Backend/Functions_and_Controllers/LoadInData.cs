using fitnesz_terem.Database_Backend.Connection;
using fitnesz_terem.Database_Backend.Modells_Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
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
                        string[] labels = { "Administrator", "Private Coach", "Trainee", "Guest" };

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

                
            });
        }
    }
}
