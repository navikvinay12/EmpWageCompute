namespace EmployeeWageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWage("Tata", 30, 14, 40);
            empWageBuilder.ComputeEmpWage();
        }
    }
}