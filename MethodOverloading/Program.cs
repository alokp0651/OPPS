namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {   
           
            Console.WriteLine("Hello, World!");
        }

        public static void ADD(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}",FN+SN);
        }
        public static void ADD(float FN, float SN)       //same name method with diffrent type of parameter(overloading)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void ADD(int FN, float SN)      
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }


        ///////////////////////////////Overloading using diffrent kind of parameter///////////////////////////////////


        public static void ADD(int FN, int SN,int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }
        public static void ADD(int FN, int SN,out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            Sum = FN + SN;
        }


        ///////////////Method with the diffrent return type will give the compiler error/////////////////

        public static void Sum(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }
        public static int Sum(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
            return FN + SN + TN;
        }

        ////////////Method with param keyword and with normal arrray give error/////////////////////////////

        public static void Sum(int FN, int SN,params int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN );
        }
        public static void Sum(int FN, int SN, int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
    }
}