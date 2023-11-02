namespace Properties
{

    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive integer:");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                long result = CalculateFactorial(n);
                Console.WriteLine($"Factorial of {n} is: {result}");
            }
            else
            {
                Console.WriteLine("Please enter a non-negative integer.");
            }
        }

        // Function to calculate factorial using recursion
        public static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * CalculateFactorial(n - 1);
        }
    }
}