using NetSalaryCalc.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetSalaryCalc.Models
{
    public class Contract
    {
        //swagger url https://localhost:49163/swagger/index.html

        [Required]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage ="Must be string and white spaces")]
        [MinWordAttributes(2)]
        public string FullName { get; set; }

        [CustomDate(ErrorMessage = "Invalid date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        //[RegularExpression(@"^\d+\.\d{0,2}$")]
        public double GrossIncome { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{5,10}$", ErrorMessage = "Must be from 5 to 10 numeric characters only.")]
        public string SSN { get; set; }

        //[RegularExpression(@"^\d+\.\d{0,2}$")]
        public double CharitySpent { get; set; }
    }
}
