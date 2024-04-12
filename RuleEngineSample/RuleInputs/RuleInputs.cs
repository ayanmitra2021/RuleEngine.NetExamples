using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleEngineSample.RuleInputs
{
    public class DiscountInputs : IRuleInput
    {
        public string country = "india";
        public int loyaltyFactor = 4;
        public decimal totalPurchasesToDate = 15500;
    }

    public class MemberInput : IRuleInput
    {
        public string name = "Jane Doe";
        public decimal salary = 6000;
        public string gender = "F";
        public int age = 52;
        public string stateCode = "IL";
        public string extraCode5 = "A2";
        public decimal annualSalary = 312600;
        public int extraInt1 = 3;
        public decimal forzenSalary = 2500;
        public string managerEmployeeNo = "3A";
        public string fullOrPartTimeCode = "FT";
    }

    public class DependentInput : IRuleInput
    {
        public string name = "John Doe";
        public string gender = "M";
        public int age = 42;
    }

    public class SubjectScore : IRuleInput
    {
        public int science = 84;
        public int math = 75;
        public string studname = "Krishna Kumar";
    }

    public class HRIS : IRuleInput
    {
        public decimal? ExtraAmount8 = 5000;
        public decimal? AnnualSalary = 7500;
    }

    public class Pension : IRuleInput
    {
        public decimal? ExtraAmount7 = 5000;
        public string? ExtraCode5 = "A";
        public decimal? ExtraAmount8 = 6000;
        public decimal? AnnualSalary = 7500;
    }

}
