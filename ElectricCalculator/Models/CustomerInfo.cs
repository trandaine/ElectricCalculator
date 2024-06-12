using ElectricCalculator.Models;
using ElectricCalculator22222.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCalculator22222.Models
{
    public class CustomerInfo
    {
        [MaxLength(PConstants.ID_MAX_LENGTH)]
        public string Id { get; set; }
        [MaxLength(200)]
        public string Adress { get; set; }
        [Phone]
        public string Phone { get; set; }
       [EmailAddress]
        public string Email { get; set; }

        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
