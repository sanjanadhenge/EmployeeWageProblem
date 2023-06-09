using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWage
    {
        CompanyWage companyWage = new CompanyWage();
        List<CompanyWage> list = new List<CompanyWage>();
        Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
        const int ispresent = 1, Full_Day_Hr = 8, Part_Time_Hr = 4, Is_Full_Time = 0, Is_Part_Time = 1;
        int[] TotalWage = new int[10];
        String[] Name = new String[10];
        int j = 0, k = 0;
        public void CheckAttendance()
        {

            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == ispresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void DailyWage(String CompanyName, int Wage_Per_Hr, int Total_working_days, int Total_Working_Hrs)
        {
            int[] dailywages = new int[100];
            int m = 0;
            CompanyWage companyWage = new CompanyWage();
            Name[k] = CompanyName;
            companyWage.companyName = CompanyName;
            k++;
            int empHrs = 0;
            int i = 0;
            while (i < Total_working_days && empHrs <= 100)
            {
                i++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case Is_Full_Time:
                        empHrs += Full_Day_Hr;
                        break;
                    case Is_Part_Time:
                        empHrs += Part_Time_Hr;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
                int daywage = empHrs*Wage_Per_Hr;
                dailywages[m]= daywage;
                m++;
            }
            dict.Add(CompanyName, dailywages);
            int wage = Wage_Per_Hr * empHrs;
            TotalWage[j] = wage;
            companyWage.Totalwages = wage;
            j++;
            Console.WriteLine(CompanyName + "---->" + "Total Wage =" + wage);
            list.Add(companyWage);
        }
        public void DisplayCompanyWages()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Company Name => " + item.companyName + "Total Wage =>" + item.Totalwages);
                foreach(var item1 in dict)
                {
                    foreach(var w in item1.Value)
                    {
                        Console.WriteLine("Daily wage =>" + w);
                    }
                }
            }
        }
    }
}