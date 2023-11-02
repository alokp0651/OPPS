//Overriding Virtual method
//Polymorphism


namespace Polymorphism
{

    public class Employee
    {
        public string FirstName = "Fn";
        public string LastName = "Ln";

        public virtual void PrintFullname() //<<<<----To use override Keyword we will use Virtual in base class method  (So any Derived class override the virtual method of base class when methos is marked as virtual)
        { 
            Console.WriteLine(FirstName +" "+ LastName);
        }

    }
    public class FulltimeEmployee : Employee
    {
        //public void PrintFullname()       
        //{

        //    Console.WriteLine(FirstName + " " + LastName + " " + "_Fulltime");
        //}
        /// <summary>
        /// This Overriden method of respective class which invoked at runtime are nothing but polymorphism
        /// </summary>
        public override void PrintFullname()    //<<<<<------just Write override and press space it will show you the method which have to override and select 
        {
            // base.PrintFullname();
            Console.WriteLine(FirstName + " " + LastName + " " + "_Fulltime");
        }
    }
    public class ParttimeEmployee : Employee
    {
        //public void PrintFullname()
        //{

        //    Console.WriteLine(FirstName + " " + LastName + " " + "_PartTime");
        //}
        public override void PrintFullname()
        {
            //base.PrintFullname();
            Console.WriteLine(FirstName + " " + LastName + " " + "_PartTime");
        }
    }
    public class TemprorryEmployee : Employee
    {
        //public void PrintFullname()
        //{

        //    Console.WriteLine(FirstName + " " + LastName +" "+ "_Temprory" );
        //}

        public override void PrintFullname()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + "_Temprory");
        }
    }
    internal class Program
    {

        /// <summary>
        /// Polymorphism Basically enable you to invoked derived class method through base class refrence variable at runtime
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];   //<<<<----We are using base class Method as refrence Variable soo it will call base class method.
            employees[0] = new Employee();
            employees[1] = new FulltimeEmployee();
            employees[2]= new ParttimeEmployee();
            employees[3] = new TemprorryEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullname();
            }
        }
    }
}

//