using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [NotMapped]
        public double Longitude { get; set; }
        [NotMapped]
        public double Latitude { get; set; }


        [Key]
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [DisplayName("Zipcode")]
        public int ZipCode { get; set; }
        [DisplayName("Pickup Day")]
        public string PickupDay { get; set; }
        [DisplayName("Extra Pickup")]
        public string ExtraPickup { get; set; }
        [DisplayName("Money Owed")]
        public double MoneyOwed { get; set; }
        [DisplayName("Day service suspended")]
        public string StartDateEndOfPickups { get; set; }
        [DisplayName("Last day of suspended service")]
        public string EndDateEndOfPickups { get; set; }
        [DisplayName("Trash Collected")]
        public bool TrashCollected { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserID { get; set; }
        public IdentityUser IdentityUser { get; set; }
        

    }
}
