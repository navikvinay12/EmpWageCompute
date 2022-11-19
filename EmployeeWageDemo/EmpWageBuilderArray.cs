using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;//constants -its a part of empWage calculation .
        public const int IS_FULL_TIME = 2;
        private int numOfCompany = 0;   //initalized numOfCompany by 0 , so that it can be increased later as per the no of companies.
        private CompanyEmpWage[] companyEmpWageArray;//Array created of class CompanyEmpWage by the name companyEmpWageArray.
        public EmpWageBuilderArray()//default constructor to initialize 
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];//defined th array size as 5 (we cannot add more then 5 companies)
        }
        public void AddCompanyEmpWage(string company,int empRateperHour,int numOfWorkingDays,int maxHoursPermonth)//it will be taking company inputs passed from main method,we can keep going adding companies
        {
            companyEmpWageArray[this.numOfCompany]=new CompanyEmpWage(company,empRateperHour,numOfWorkingDays,maxHoursPermonth);//each companies object will be going created (starting from array[0] then array[1] and so on .
            numOfCompany++; //once once company details received in above line ,then to take another company data we should not take on the same location because it will override the existing data hence incrementing it to take data in another index position.
        }
        public void ComputeEmpWage()//so introduced this method where for loop will be helping to repeat the same task number of times compare to companies we do have to work with .
        {
            for(int i=0;i<numOfCompany;i++)//output from ComputeEmpWage is referred with the help of setter() used and the variable will be then holding the result which will be shown using ToString() .
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)//the main calculation for empWage will be done here and output is traversing from here .
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
