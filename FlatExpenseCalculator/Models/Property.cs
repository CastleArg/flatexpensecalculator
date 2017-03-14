using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Models
{
    public class Property
    {
        public int Id;
        public string Name;
        public IAsyncEnumerable<Room> Rooms;
        public IAsyncEnumerable<ApplicationUser> Tenants; 
    }
}
