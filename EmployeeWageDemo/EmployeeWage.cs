namespace EmployeeWageDemo
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage Computation");

            int IS_FULL_TIME = 1;       //Constants
            Random random = new Random();

            int empCheck=random.Next(0,2);  //0 or 1
            if(empCheck== IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");   //1-->Employee is Present
            }
            else
            {
                Console.WriteLine("Employee is Absent");    //0-->Employee is Absent
            }
            Console.ReadLine();
        }
    }
}