using FlatExpenseCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Property.Any())
            {
                return;
            }

            var tenants = new ApplicationUser[]
            {
                new ApplicationUser
                {
                    UserName = "Livvy"
                },
                 new ApplicationUser
                {
                    UserName = "Sam"
                },
                  new ApplicationUser
                {
                    UserName = "Kieran"
                },
                   new ApplicationUser
                {
                    UserName = "Debbie"
                },
                    new ApplicationUser
                {
                    UserName = "Mark"
                },
                     new ApplicationUser
                {
                    UserName = "Oswald"
                }
            };

            foreach (var tenant in tenants)
            {
                if (!context.Users.Any(x => x.UserName == tenant.UserName))
                {
                    context.Users.Add(tenant);
                }
            }
            context.SaveChanges();

            var properties = new Property[]
            {
                new Property
                {
                    Name = "Russley 302",
                    CurrentTotalRent = 590.00M,
                    DateApplied = DateTime.UtcNow,
                    Rooms = new Room[]
                    {
                        new Room
                        {
                            Name = "Room 1",
                            AreaM2 = 18,
                            RentPerWeek = 140,
                            Occupants = new List<ApplicationUser>
                            {
                                context.Users.SingleOrDefault(x=>x.UserName == "Kieran")
                            }
                        },
                          new Room
                        {
                            Name = "Room 2",
                            AreaM2 = 18,
                            RentPerWeek = 200,
                              Occupants = new List<ApplicationUser>
                            {
                                context.Users.SingleOrDefault(x=>x.UserName == "Debbie"),
                                context.Users.SingleOrDefault(x=>x.UserName == "Mark")
                            }
                        },
                            new Room
                        {
                            Name = "Room 3",
                            AreaM2 = 18,
                             RentPerWeek = 110,
                              Occupants = new List<ApplicationUser>
                            {
                                context.Users.SingleOrDefault(x=>x.UserName == "Oswald")
                            }
                        },
                              new Room
                        {
                            Name = "Room 4",
                            AreaM2 = 18,
                            RentPerWeek = 110,
                             Occupants = new List<ApplicationUser>
                            {
                                context.Users.SingleOrDefault(x=>x.UserName == "Livvy")
                            }
                        },
                                new Room
                        {
                            Name = "Room 5",
                            RentPerWeek = 210,
                             Occupants = new List<ApplicationUser>
                            {
                                context.Users.SingleOrDefault(x=>x.UserName == "Sam")
                            }
                        }
                    }

                }
            };

            foreach (var property in properties)
            {
                context.Property.Add(property);
            }
            context.SaveChanges();

        }
    }
}
