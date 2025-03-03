﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
    class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
        }
    }
}
