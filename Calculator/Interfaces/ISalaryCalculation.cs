using Calculator.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Interfaces
{
    public interface ISalaryCalculation
    {
        TaxesContext GetData(ContractContext taxPayerContr);
    }
}
