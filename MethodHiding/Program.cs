namespace MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName +" "+ LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {

    }
    public class PartTimeEmployee : Employee 
    {
        public new void PrintFullName()      //<-------- This "PrintFullName" method in "PartTimeEmployee" class hide "PrintFullName" method of "Employee" class the green line showing the waring when we hower the mouse. So if you hiding the "Employee" class method intentionally just use "new" Keyword the it will not give the warning .
        {

           // base.PrintFullName(); //<---------- "base" keyword is used to invoke the hidden method of base class Employee.
            Console.WriteLine(FirstName + " " + LastName + "- Contractor");     
        }
    }
  
    internal class Program
    {

        
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee(); 
            FTE.FirstName = "Alok";
            FTE.LastName = "Pandey";
            FTE.PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Sonam";
            PTE.LastName = "Pandey";
            //PTE.PrintFullName();
            ((Employee)PTE).PrintFullName(); //<------this is the another way to call hidden method of the "Employee" class.(Cast child type to parent type and invoke the hidden member)


            //Employee PTE = new PartTimeEmployee(); //<------this is the another way to call hidden method of the "Employee" class Making "PTE" Variable as "Employee" type (" This point means that Parent class refrence variable point child class object but the vice Versa can ty be done ")
            //PTE.FirstName = "Sonam";
            //PTE.LastName = "Pandey";                                         
            //PTE.PrintFullName();
        }
    }
}