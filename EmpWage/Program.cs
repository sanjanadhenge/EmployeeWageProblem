﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("<----Welcome to Employee Wage Computation---->");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.DailyWage("Reliance", 20, 20, 100);
            employeeWage.DailyWage("Atos", 22, 18, 95);
            employeeWage.DailyWage("HCL", 24, 22, 102);
            employeeWage.DailyWage("BirlaSoft", 20, 25, 92);
            employeeWage.DisplayCompanyWages();
            Console.WriteLine("<----Welcome to Employee Wage Computation using OOPS Concepts---->");
            Finalsolution finalsolution = new Finalsolution();
            finalsolution.AddCompanyWage("Reliance", 20, 20, 100);
            finalsolution.AddCompanyWage("Atos", 22, 18, 95);
            finalsolution.AddCompanyWage("HCL", 24, 22, 102);
            Console.WriteLine("Total Wage for HCL : "+finalsolution.GetTotalWage("HCL"));

        }
    }
}
