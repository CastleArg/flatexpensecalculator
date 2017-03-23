using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlatExpenseCalculator.Models
{
    public class Property
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<ApplicationUser> Tenants { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal CurrentTotalRent { get; set; }
        public DateTime DateApplied { get; set; }
    }
}
