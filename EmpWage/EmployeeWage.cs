using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWage
    {
        const int ispresent = 1,Wage_Per_Hr =20,Full_Day_Hr= 8, Part_Time_Hr = 4, Is_Full_Time = 1, Is_Part_Time = 2;
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
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == Is_Full_Time)
            {
                empHrs += Full_Day_Hr;
            }
            if (check == Is_Part_Time)
            {
                empHrs += Part_Time_Hr;
            }
            else
            {
                empHrs = 0;
            }
            int wage = Wage_Per_Hr * empHrs;
            Console.WriteLine("Daily Wage " + wage);
        }
        
    }
}
