using ElectricCalculator.Models;
using ElectricCalculator.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ElectricCalculator.Models
{
    public class CustomerInfo
    {
        //[MaxLength(PConstants.ID_MAX_LENGTH, ErrorMessage="Khong duoc dai hon{1}")]
        [MaxLength(36)]
        [Description("Customer unique ID code")]
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
