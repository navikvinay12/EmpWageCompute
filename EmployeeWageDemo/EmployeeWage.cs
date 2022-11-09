using System;

namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck=random.Next(0,3);
            switch (empCheck)
            {
                case IS_FULL_TIME :
                    Console.WriteLine("Full Time Employee is Present");
                    empHrs = 8;
                    break;
                case IS_PART_TIME :
                    Console.WriteLine("Part Time Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage : "+empWage);
            Console.ReadLine();
        }
    }
}