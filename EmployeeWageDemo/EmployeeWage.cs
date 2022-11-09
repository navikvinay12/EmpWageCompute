namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck=random.Next(0,3);
            if(empCheck== IS_FULL_TIME)
            {
                Console.WriteLine("Full Time Employee is Present");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Part Time Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage : "+empWage);
            Console.ReadLine();
        }
    }
}