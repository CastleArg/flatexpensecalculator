using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Models
{
    public class Room
    {
        public int Id;
        public string Name;
        public float AreaM2;
        public IAsyncEnumerable<ApplicationUser> Occupants;
    }
}
