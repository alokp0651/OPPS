namespace DiffrencebetweenValueAndRefrenceType
{
    class demo
    {
        public int m;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10; // in value type of variable has value in stack (variable istself hold the value in stack it has no refrence object in heap) 

            string s = "Alok"; // where as the value of refrence type variable is refrence to value(object) on heap this is happen because size of a refrence type variable value keep on changing
            demo d = new demo(); //here object is created so value is in the heap
            Console.WriteLine("Hello, World!");
        }
    }
}