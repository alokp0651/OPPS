namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "\"string\""; //escape sequence
            string name2 = "one\ntwo\nthree"; 
            string name3 = @"one\\two\\three"; //escape sequence used as regular printable charachter(Verbatim literal)
            Console.WriteLine(name);
            Console.WriteLine(name2);
            Console.WriteLine(name3);

        }
    }
}