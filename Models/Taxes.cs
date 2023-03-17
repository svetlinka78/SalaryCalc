using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetSalaryCalc.Models
{
    public class Taxes
    {
        public double GrossIncome { get; set; } = 0;
        public double CharitySpent { get; set; } = 0;
        public double IncomeTax { get; set; } = 0;
        public double SocialTax { get; set; } = 0;
        public double TotalTax { get; set; } = 0;
        public double NetIncome { get; set; } = 0;
    }
}
