﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital2
{
    class Janitor : Employee
    {
        public bool IsSweeping { get; set; }
        public double EmployeeSalary { get; set; }


        public Janitor(string employeeName, int employeeNumber, bool isSweeping) : base(employeeName, employeeNumber, 40000)
        {
            IsSweeping = isSweeping;
            EmployeeSalary = 40000.00;
        }
        public override void PrintEmployee()
        {
            base.PrintEmployee();
            Console.WriteLine("Sweeping Status: " + IsSweeping);
        }
        public override void PayEmployee()
        {
            base.PayEmployee();
            Console.WriteLine("Salary: " + EmployeeSalary);
        }
    }
}
