using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalc.Helpers
{
    public class CustomDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        { 
            DateTime d = Convert.ToDateTime(value);
            return d <= DateTime.Now; 
        }
    }

    public class MinWordAttributes : ValidationAttribute
    {
        private readonly int _minWords;
        public MinWordAttributes(int minWords)
        {
            _minWords = minWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;
            var textValue = value.ToString().Trim();
            return textValue.Split(' ').Length < _minWords
                ? new ValidationResult("Full Name must be at least two words!")
                : ValidationResult.Success;
        }
    }
}
