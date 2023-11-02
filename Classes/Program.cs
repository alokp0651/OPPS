//What is class?
//Purpose of Constructor
//Overloadind Class Constructor
//understand This Keywoed 
//Destructor

// A class consist of data and behavior. class data is represented by it's fields and behaiviour is represented by its methods
namespace Classes
{

    class Customer
    {
        string _firstName;
        string _lastName;


        //public Customer()
        //: this("no firstname", "no last name")
        //{
        //}

        public Customer(string FirstName, string LastName)  // Constructor (is used to inintialize the class field) it do not have return type (Constructor can be overloaaded by the number and type of parameter)
        {
           this._firstName = FirstName;                   //This keyword actual refered instant or object of "Customer" class for better  readibitly you can use this keyword otherwise you can use directly
           this._lastName = LastName;
             
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name ={0}",this._firstName+" "+this._lastName);
        }

        ~Customer()  // distructor are commonly used to clean the resources (Object) and it will automatically called by the garbage collector distructor name is also same as the class name 
        {            //distructor dont have parameter and return type
            //clean up code
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer C1 = new Customer("Alok", "Pandey"); // constructor will be get call automatically when we create the instance of the Customer class we have passed the parameter according to customer constructor.
            C1.PrintFullName();

            //Customer C2 = new Customer();
        }
    }

    //if we not defined constructor .net framework automatically define parameter less default constructor.
}