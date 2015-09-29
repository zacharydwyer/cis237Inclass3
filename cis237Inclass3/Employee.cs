using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Employee
    {
        //Private variables
        private string firstName;
        private string lastName;
        private string department;

        //Propertiest for variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        //3 Parameter Constructor
        public Employee(string FirstName, string LastName, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.department = Department;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        // Public - can be accessed by itself, its inheritants, and everyone else
        // Protected - can be accessed by itself and its inheritants
            // virtual - any of my subclasses are allowed to override this method
        // Private - can only be accessed by itself

        protected virtual void PrintFullName()                                  
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
    }
}
