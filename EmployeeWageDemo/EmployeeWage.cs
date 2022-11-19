using System;

namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;      //variables
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)       //computation
            {
                totalWorkingDays++;
                Random random = new();
                int empCheck = random.Next(3);
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
                totalEmpHrs += empHrs;//as the no of working days will be passing the total no of working hrs will going on added of each day accordingly .
                if (totalEmpHrs > maxHoursPerMonth)  //totalEmpHrs should not go beyond defined MaxHrs .
                {
                    totalEmpHrs = maxHoursPerMonth;
                }
                //Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;//per hour rate * total working hour to find wage .
            Console.WriteLine($"Total Emp Wage for the Company \"{company}\" is : {totalEmpWage}");
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 3, 10);
            ComputeEmpWage("Reliance", 25, 4, 20);
        }
    }
}