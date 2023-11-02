namespace AbstractClassAndAbstractMethod
{
    abstract class Animal      // Abstract class decalared using abstract keyword 
    {
        public abstract void animalSound(); // abstarct method is just used in abstarct class. the body of abstract method not Defined  in abstarct class body is defined in derived class
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); // Error: Abstarct class object is not be creacted (To access the abstract class, it must be inherited from another class.)
        }
    }
}


//// Abstract class
//abstract class Animal
//{
//    // Abstract method (does not have a body)
//    public abstract void animalSound();
//    // Regular method
//    public void sleep()
//    {
//        Console.WriteLine("Zzz");
//    }
//}

//// Derived class (inherit from Animal)
//class Pig : Animal
//{
//    public override void animalSound()
//    {
//        // The body of animalSound() is provided here
//        Console.WriteLine("The pig says: wee wee");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Pig myPig = new Pig(); // Create a Pig object
//        myPig.animalSound();  // Call the abstract method
//        myPig.sleep();  // Call the regular method
//    }
//}