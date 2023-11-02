namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 50;             //assignement operator 
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;          //Arthemetic operators
            int div = a / b;
            int mod = a % b;
            if (a != b)
            {
                if (a == 100)
                {
                    Console.WriteLine("fuckoff its a comparison operator ");  //comparison operator
                }
            }

            if (b == 50 && a == 50)
            {
                Console.WriteLine("Conditional && AND"); //Conditional && AND
            }
            if (b == 50 || a == 50)
            {
                Console.WriteLine("Conditional || OR"); //Conditional && OR
            }

            int number = 10;
            Boolean IsNumber = number == 10? true : false;
            Console.WriteLine("isnumber ={0}", IsNumber); //Ternary operator
            
            
            
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(div);
            Console.WriteLine(mul);
            Console.WriteLine(mod);
        }
    }
}