﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Employee : Human
    {
        public override void Eat()
        {
            Console.WriteLine("Employee is eating");
        }

    }
}
