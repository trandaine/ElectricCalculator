using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectricCalculator.Common;
using ElectricCalculator.Models;
using System.ComponentModel.DataAnnotations;

namespace ElectricCalculator.Models
{
    public class ElectricPrice
    {
        // Data annotation for tinyint
        [Range(0, 255)]
        public int Id { get; set; }

        [Range(0, 255)]
        public int Range { get; set; }

        // Data annotation for decimal
        [Range(0, 999999999999999)]
        public double Price { get; set; }
    }
}
