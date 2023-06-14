using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public interface IComputewage
    {
        public void  AddCompanyWage(String CompanyName, int Wage_Per_Hr, int Total_working_days, int Total_Working_Hrs);
        public void ComputeWage();
        public int GetTotalWage(String CompanyName);
    }
    public class CompanyWages
    {
        public String CompanyName;
        public int Wage_Per_Hr;
        public int Total_working_days;
        public int Total_Working_Hrs;
        public int TotalWage;
        public CompanyWages(String CompanyName, int Wage_Per_Hr, int Total_working_Days, int Total_Working_Hrs)
        {
            this.CompanyName = CompanyName;
            this.Wage_Per_Hr = Wage_Per_Hr;
            this.Total_working_days = Total_working_Days;
            this.Total_Working_Hrs=Total_Working_Hrs;
            this.TotalWage = 0;
        }
        public void GetTotalEmpWage(int TotalWage)
        {
            this.TotalWage= TotalWage;
        }
        public string tostring()
        {
            return "Total Emp wage for company : "+this.CompanyName + "is : "+ this.TotalWage;
        }


    }
    public class Finalsolution : IComputewage
    {
        public const int Is_Full_Time = 2, Is_Part_Time = 1;
        public LinkedList<CompanyWages> Wages;
        public Dictionary<string, CompanyWages> WagesDict;
        public Finalsolution()
        {
            this.Wages = new LinkedList<CompanyWages>();
            this.WagesDict = new Dictionary<string, CompanyWages>();
        }
        public void AddCompanyWage(string CompanyName, int Wage_Per_Hr, int Total_working_days, int Total_Working_Hrs)
        {
            CompanyWages companyWages = new CompanyWages( CompanyName, Wage_Per_Hr,  Total_working_days,  Total_Working_Hrs);
            this.Wages.AddLast(companyWages);
            this.WagesDict.Add(CompanyName, companyWages);
        }

        public void ComputeWage()
        {
           foreach(CompanyWages companyWages in this.Wages)
            {
                companyWages.GetTotalEmpWage(ComputeEmpWage(companyWages));
                Console.WriteLine(companyWages.tostring());
            }
        }
        public int ComputeEmpWage(CompanyWages companyWages)
        {
            int empHrs = 0, total_working_days=0;
            int i = 0;
            while (i < companyWages.Total_working_days && empHrs <= 100)
            {
                total_working_days++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case Is_Full_Time:
                        empHrs += 8;
                        break;
                    case Is_Part_Time:
                        empHrs += 4;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
                
            }
           
            int wage = companyWages.Wage_Per_Hr * empHrs;
            return wage;
        }
       public int GetTotalWage(string CompanyName)
        {
            return this.WagesDict[CompanyName].TotalWage;
        }
    }
}
