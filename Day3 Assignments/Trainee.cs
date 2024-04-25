using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day3_Assignments
{
    internal class Trainee : Person , IPlayable //, IComparer<Person>
    {
        int _NID;
        int _intakeNumber; 
        public decimal Salary { get; set; }
        public Trainee(int NID, int intakeNumber)
        {
            _NID = NID;
            _intakeNumber = intakeNumber;
        }
        public Trainee()
        {
            _NID = default;
            _intakeNumber = default;
        }
        public override string ToString()
        {
            return $"\nthis Trainee NID is : {_NID} \t and his intake number is : {_intakeNumber}";
        }
        public decimal ShowPayment()
        {
          return Salary;
        }
        //public int Compare(Trainee t1, Trainee t2)
        //{
        //    return t1.Salary.CompareTo(t2.Salary);
        //}
        //public int Compare(Trainee t1, Trainee t2)
        //{
        //    return ((new CaseInsensitiveComparer()).Compare(t1, t2));
        //}
    }
}
