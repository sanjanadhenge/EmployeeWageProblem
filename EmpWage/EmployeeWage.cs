using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWage
    {
        const int ispresent = 1,Wage_Per_Hr =20,Full_Day_Hr= 8, Part_Time_Hr = 4, Is_Full_Time = 0, Is_Part_Time = 1, Total_working_days = 20;
        public void CheckAttendance()
        {
          
            Random random = new Random();
            int check = random.Next(0,2);
            if(check == ispresent )
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void DailyWage()
        {

            int empHrs = 0;
            for(int i=0;i<Total_working_days;i++)
            {
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
            }
           

            int wage = Wage_Per_Hr * empHrs;
            Console.WriteLine("Daily Wage " + wage);
        }
        
    }
}
