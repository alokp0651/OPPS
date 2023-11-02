 namespace DiffBetweenMethodOverrridingAndMethodHiding
{
    public class BaseClass
    {
        public virtual void print()
        {
            Console.WriteLine("I am base class print method");
        }
    }
    //public class DerivedClass:BaseClass            //method overriding a base class refrence varable i.e(BaseClass b) pointing a child class object (new DerivedClass()),will invoke the ovverridden method in child class.
    //{
    //    public override void print()
    //    {

    //        Console.WriteLine("I am Derived class print method");
    //    }
    //}
    public class DerivedClass : BaseClass
    {
        public new void print()      ////method Hidding a base class refrence varable i.e(BaseClass b) pointing a child class object (new DerivedClass()),will invoke the hidden method in base class
        {
           Console.WriteLine("I am  Derived class print method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();                  
            b.print();

            DerivedClass D = new DerivedClass(); // this actually called the direved class print method and hide base class method when we are using "new"
            b.print();
        }
    }
}