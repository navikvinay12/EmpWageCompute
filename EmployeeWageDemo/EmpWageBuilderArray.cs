using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPermonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRateperHour, numOfWorkingDays, maxHoursPermonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void ComputeEmpWage()
        {
            Console.WriteLine("Enter your company name so that we will show you the details of your employee wage");
            string verifyingCompany;
            verifyingCompany = Console.ReadLine();
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                if (companyEmpWage.company != verifyingCompany)     //filtering code added to provide only specific comp emp wage UC14 .
                {
                    continue;
                }
                else
                {
                    companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.ToString());
                }
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)//the main calculation for empWage will be done here and output is traversing from here .
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}