using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignments
{
    internal class Person
    {
        string _name; 
        int _age; 
        public Person(string name , int age)
        { 
            _name = name;
            _age = age;
        }
        public Person()
        {
            _name = "Unknown";
            _age = default;
        }
        public override string ToString()
        {
            return $"\nthis person name is : {_name} \t and his age is : {_age}";
        }

    }
}
