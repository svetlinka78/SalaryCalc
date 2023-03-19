using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Context
{
  
        public class TaxesContext
        {
            public double GrossIncome { get; set; } = 0;
            public double CharitySpent { get; set; } = 0;
            public double IncomeTax { get; set; } = 0;
            public double SocialTax { get; set; } = 0;
            public double TotalTax { get; set; } = 0;
            public double NetIncome { get; set; } = 0;

        }
}
