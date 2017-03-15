using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float AreaM2 { get; set; }
        public IEnumerable<ApplicationUser> Occupants { get; set; }
    }
}
