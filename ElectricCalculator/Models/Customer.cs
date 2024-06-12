using ElectricCalculator22222.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCalculator.Models
{
    public class Customer
    {
        [MaxLength(12)]
        public string Id { get; set; }
        [MaxLength(75)]
        public string FullName { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(25)]
        public DateTime DateOfBirth { get; set; }

        public string CustomerInfoId { get; set; }
        public virtual CustomerInfo CustomerInfo { get; set; }
    }
}




