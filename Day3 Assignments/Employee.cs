using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day3_Assignments
{
    internal class Employee : Person, IPlayable
    {
        private int _NID;
        private decimal _salary;
        //public decimal Salary { get; set; }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public Employee(int NID , decimal salary ) 
        {
            _NID = NID;
            _salary = salary;
        }
        public Employee()
        {
            _NID = default;
            _salary = default;
        }
        public override string ToString()
        {
            return $"\nthis Employee NID is : {_NID} \t and his salary is : {_salary}";
        }

        public decimal ShowPayment()
        {
            return Salary;
        }
    }
}
