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
            if(context.Property.Any())
            {
                return;
            }
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
                            AreaM2 = 18
                        },
                          new Room
                        {
                            Name = "Room 2",
                            AreaM2 = 18
                        },
                            new Room
                        {
                            Name = "Room 3",
                            AreaM2 = 18
                        },
                              new Room
                        {
                            Name = "Room 4",
                            AreaM2 = 18
                        },
                                new Room
                        {
                            Name = "Room 5",

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
