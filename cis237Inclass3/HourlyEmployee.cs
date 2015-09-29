using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {

        private decimal hourlyRate;
        private double hoursWorked;

        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value;  }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        // 4 Param constructor that calls the base constructor with 3 of hte parameters, then
        // assigns the last one to the hourly rate.
        public HourlyEmployee(string FirstName, string LastName, string Department, decimal HourlyRate)
            : base(FirstName, LastName, Department)
        {
            this.hourlyRate = HourlyRate;
        }

        // Do parent's toString but add the hourly rate in there as well.
            // The "c" in there is a currency code that toString can accept.
        public override string ToString()
        {
            return base.ToString() + hourlyRate.ToString("C");
        }

        // Note: did not override the printFullName protected virtual method. 
        // Since we didn't override it, calling an instance of HourlyEmployee's PrintFullName method will just call Employee's version of it.



        public decimal CalculateWeeklyGross()
        {
            return hourlyRate * (decimal)hoursWorked;
        }
    }
}
