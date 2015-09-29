using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class SalaryEmployee : Employee             // SalaryEmployee inherits from Employee
    {
        private decimal yearlySalary;           // Use decimal when dealing with money. Floats and doubles lose precision.

        public decimal YearlySalary
        {
            get { return yearlySalary; }
            set { yearlySalary = value; }
        }


        // it is different with java, which has you call the base constructor within this constructor
        public SalaryEmployee(string FirstName, string LastName, string Department, decimal YearlySalary) : base(FirstName, LastName, Department)
        {
            this.yearlySalary = YearlySalary;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.yearlySalary.ToString();
        }

        protected override void PrintFullName()
        {
            Console.WriteLine(base.ToString() + " " + this.yearlySalary.ToString());
        }

        // A public method to return the weekly gross of the employee
        public decimal CalculateWeeklyGross()
        {
            return this.yearlySalary / 52;
        }
    }
}
