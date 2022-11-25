using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public class EmpWageBuilderArray : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;   
        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company,int empRateperHour,int numOfWorkingDays,int maxHoursPermonth)
        {
            companyEmpWageArray[this.numOfCompany]=new CompanyEmpWage(company,empRateperHour,numOfWorkingDays,maxHoursPermonth);
            numOfCompany++; 
        }
        public void ComputeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while(totalEmpHrs<= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random= new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:"+totalWorkingDays+ "Emp Hrs : "+empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
