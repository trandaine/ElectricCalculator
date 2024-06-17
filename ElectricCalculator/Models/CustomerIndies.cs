using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricCalculator.Models;
using ElectricCalculator.Common;
using System.ComponentModel.DataAnnotations;

namespace ElectricCalculator.Models
{
    public class CustomerIndies
    {
        [Range(0,99999)]
        public string Id { get; set; }

        // data annotation for smallint
        [Range(0, 65535)]
        public string CurrentIndex { get; set; }

        [Range(0, 65535)]
        public string LastIndex { get; set; }

        [Range(0, 65535)]
        public string ConsumerIndex { get; set; }

        [Range(0, 99999999999)]
        public decimal Cost { get; set; }

        [MaxLength(25)]
        public DateTime DateRecorded { get; set; }

        [MaxLength(25)]
        public DateTime DateCreated { get; set; }

        public int Month { get; set; }

        //[MaxLength(5)]
        //public string Year { get; set; }
        public int Year { get; set; }

        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public string EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
