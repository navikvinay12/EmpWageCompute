using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDemo
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)//initializing all variabeles
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int totalEmpWage)//setter method used to set the value of empWage of this class ("this" keyword has been used as an reference for current class instance variable)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public override string ToString()//representing objects into string so it can be readable .
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
