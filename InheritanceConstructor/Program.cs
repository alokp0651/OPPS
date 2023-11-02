namespace InheritanceConstructor
{
    public class parentClass
    {
        public parentClass() 
        {
            Console.WriteLine("Parentclass Constructor Called");
        }
        public parentClass(string Message) 
        { 
            Console.WriteLine(Message);
        }
}

    public class childClass : parentClass
    {
        public childClass() : base("Derived clss controlling parent class") 
        {
            Console.WriteLine("ChildClass constructor called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           childClass CC = new childClass();
           
        }
    }
}