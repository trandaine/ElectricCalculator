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
    public class Employee
    {
        [MaxLength(PConstants.ID_MAX_LENGTH)]
        public string Id { get; set; }

        [MaxLength(75)]
        public string Name { get; set; }
    }
}
