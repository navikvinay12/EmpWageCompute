namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");

            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empCheck=random.Next(0,2);
            if(empCheck== IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
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