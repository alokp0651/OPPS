using System.Runtime.Intrinsics.X86;

namespace Inheritance
{
    /// <summary>
    /// code reused in inheritance . inheritance promote reusabilty.
    /// C# only used single line Inheritance.
    /// C# Support multiple interface Inheritance.
    /// base class automitaclly instantiated before base class.
    /// parent class constructor executes before child class constructor
    /// </summary>
    /// 
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void Printfullname()
        {
            Console.WriteLine();
        }
    }
    //class A
    //{ 

    //}
    //public class FullTimeEmployee:Employee,A // this will show error because multiple base class cant be inherited
    //{
    //    public float YearlySalary;
    //} 
    
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }
    class A: FullTimeEmployee // multilevel class inheritance is possible 
    {

    }

    public class PartTimeEmployee:Employee
    {
        public float Hourlyrate;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName= "Test";
            FTE.LastName= "tww";
            FTE.YearlySalary = 587934;
            FTE.Printfullname();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName= "Test";
            PTE.LastName= "giii";
            PTE.Hourlyrate = 87899;


        }
    }
}