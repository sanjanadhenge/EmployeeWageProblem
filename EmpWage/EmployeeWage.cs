using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmployeeWage
    {
        const int ispresent = 1,Wage_Per_Hr =20,Full_Day_Hr=8;
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
            int wage = Wage_Per_Hr * Full_Day_Hr;
            Console.WriteLine("Daily Wage is => "+wage);
        }
        
    }
}
