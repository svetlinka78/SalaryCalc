using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Context;

namespace Calculator.Tests
{
    [TestClass()]
    public class SalaryCalculationTests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            var calc = new SalaryCalculation();
            var salary = new ContractContext
            { 
                CharitySpent = 0,
                GrossIncome = 3400
            };
            var taxes = calc.GetData(salary);

            var result = new TaxesContext()
            {
                GrossIncome = 3400,
                CharitySpent = 0,
                IncomeTax = 240,
                SocialTax = 300,
                TotalTax = 540,
                NetIncome = 2860
            };
            Assert.AreEqual(result.IncomeTax, taxes.IncomeTax);
            Assert.AreEqual(result.NetIncome, taxes.NetIncome);
            Assert.AreEqual(result.SocialTax, taxes.SocialTax);
            Assert.AreEqual(result.TotalTax, taxes.TotalTax);
            Assert.AreEqual(result.GrossIncome, taxes.GrossIncome);
            Assert.AreEqual(result.CharitySpent, taxes.CharitySpent);

            salary = new ContractContext
            {
                CharitySpent = 520,
                GrossIncome = 3600
            };
             result = new TaxesContext()
            {
                GrossIncome = 3600,
                CharitySpent = 520,
                IncomeTax = 224,
                SocialTax = 300,
                TotalTax = 524,
                NetIncome = 3076


            };

            taxes = calc.GetData(salary);
            Assert.AreEqual(result.IncomeTax, taxes.IncomeTax);
            Assert.AreEqual(result.NetIncome, taxes.NetIncome);
            Assert.AreEqual(result.SocialTax, taxes.SocialTax);
            Assert.AreEqual(result.TotalTax, taxes.TotalTax);
            Assert.AreEqual(result.GrossIncome, taxes.GrossIncome);
            Assert.AreEqual(result.CharitySpent, taxes.CharitySpent);

            salary = new ContractContext
            {
                CharitySpent = 10,
                GrossIncome = 900
            };
            result = new TaxesContext()
            {
                GrossIncome = 900,
                CharitySpent = 10,
                IncomeTax = 0,
                SocialTax = 0,
                TotalTax = 0,
                NetIncome = 900
            };

            taxes = calc.GetData(salary);
            Assert.AreEqual(result.IncomeTax, taxes.IncomeTax);
            Assert.AreEqual(result.NetIncome, taxes.NetIncome);
            Assert.AreEqual(result.SocialTax, taxes.SocialTax);
            Assert.AreEqual(result.TotalTax, taxes.TotalTax);
            Assert.AreEqual(result.GrossIncome, taxes.GrossIncome);
            Assert.AreEqual(result.CharitySpent, taxes.CharitySpent);


            salary = new ContractContext
            {
                CharitySpent = 0,
                GrossIncome = 980
            };
            result = new TaxesContext()
            {
                GrossIncome = 980,
                CharitySpent = 0,
                IncomeTax = 0,
                SocialTax = 0,
                TotalTax = 0,
                NetIncome = 980
            };

            taxes = calc.GetData(salary);
            Assert.AreEqual(result.IncomeTax, taxes.IncomeTax);
            Assert.AreEqual(result.NetIncome, taxes.NetIncome);
            Assert.AreEqual(result.SocialTax, taxes.SocialTax);
            Assert.AreEqual(result.TotalTax, taxes.TotalTax);
            Assert.AreEqual(result.GrossIncome, taxes.GrossIncome);
            Assert.AreEqual(result.CharitySpent, taxes.CharitySpent);

            salary = new ContractContext
            {
                CharitySpent = 150,
                GrossIncome = 2500
            };
            result = new TaxesContext()
            {
                GrossIncome = 2500,
                CharitySpent = 150,
                IncomeTax = 135,
                SocialTax = 202.5,
                TotalTax = 337.5,
                NetIncome = 2162.5
            };

            taxes = calc.GetData(salary);
            Assert.AreEqual(result.IncomeTax, taxes.IncomeTax);
            Assert.AreEqual(result.NetIncome, taxes.NetIncome);
            Assert.AreEqual(result.SocialTax, taxes.SocialTax);
            Assert.AreEqual(result.TotalTax, taxes.TotalTax);
            Assert.AreEqual(result.GrossIncome, taxes.GrossIncome);
            Assert.AreEqual(result.CharitySpent, taxes.CharitySpent);


        }
    }
}