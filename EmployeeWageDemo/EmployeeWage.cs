namespace EmployeeWageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();//class object created bcoz we wnated to use its method
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10); //using object we called the method which will be taking input.
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWage("Tata", 30, 14, 40);//max of 5 companies inputs we can give here bcoz of array size initialized it with size 5 .
            empWageBuilder.ComputeEmpWage();//calling this method bcoz the empWage calculation is done in these method only return we will get the empWage .
        }
    }
}
