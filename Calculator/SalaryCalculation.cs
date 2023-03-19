using Calculator.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SalaryCalculation : Interfaces.ISalaryCalculation
        {

        private static List<PoliceContext> _polices = new List<PoliceContext>();
        public SalaryCalculation()
        {
            _polices.AddRange(new PoliceContext[]{
            new PoliceContext {Id = 0,LimitMin = 1000, LimitMax=0,Percent =0,Formula ="(S-1000) "},
            new PoliceContext {Id = 1,LimitMin = 1000, LimitMax= 1000,Percent =10,Formula ="(S-1000)*P"},
            new PoliceContext {Id = 2,LimitMin = 1000,LimitMax = 3000,Percent = 15,Formula ="(3000-1000)*P" },
            new PoliceContext {Id = 3,LimitMin = 0, LimitMax = 0.1 ,Percent = 0,Formula ="(S-1000)- C" }

            });     
           _polices.OrderBy(x => x.Id).ToList().AsReadOnly();

        }

        //should calc 1
        // and in concurrency (calc2 and calc3)
        //public async Task GetDataAsync()
        //{
        //    await _bl.GetDataAsync();
        //}

        public TaxesContext GetData(ContractContext taxPayerContr)
        {

            var police_0 = _polices.Find(x => x.Id == 0);
            if (police_0 == null)
                return null;

            var taxes = new TaxesContext();
            var noTaxionLimit = taxPayerContr.GrossIncome > police_0.LimitMin ? police_0.LimitMin : 0;

            var police_3 = _polices.Find(x => x.Id == 3);
            if (police_3 == null)
                return null;

            var charitySpent = (taxPayerContr.CharitySpent > (police_3.LimitMax * taxPayerContr.GrossIncome)) ? police_3.LimitMax * taxPayerContr.GrossIncome : taxPayerContr.CharitySpent;
            taxes.CharitySpent = taxPayerContr.CharitySpent; 

            var police_1 = _polices.Find(x => x.Id == 1);
            if (police_1 == null)
                return null;

           
            if (taxPayerContr.GrossIncome > police_1.LimitMin)
            {
                taxes.IncomeTax = ((taxPayerContr.GrossIncome - charitySpent) - police_1.LimitMin) * police_1.Percent / 100;
            }
           

            var police_2 = _polices.Find(x => x.Id == 2);
            if (police_1 == null)
                return null;

            var grossIncomeCS = taxPayerContr.GrossIncome - charitySpent;
            var grossIncome = grossIncomeCS > police_2.LimitMax? police_2.LimitMax: grossIncomeCS;

            if (taxPayerContr.GrossIncome > police_2.LimitMin)
            {
                taxes.SocialTax = (grossIncome - police_2.LimitMin) * police_2.Percent / 100;
            }

            taxes.GrossIncome = taxPayerContr.GrossIncome;
            taxes.TotalTax = taxes.IncomeTax + taxes.SocialTax;
            taxes.NetIncome = taxes.GrossIncome - taxes.TotalTax;
            return taxes;
        }

    }
}
