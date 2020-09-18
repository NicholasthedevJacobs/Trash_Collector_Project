using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PickupDay { get; set; }
        public string ExtraPickup { get; set; }
        public double MoneyOwed { get; set; }
        public bool TrashCollected { get; set; }

    }
}
