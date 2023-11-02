//throw sho more details then Throw Ex





//namespace ThrowExAndThrow
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            { 
//                int i = Convert.ToInt32( Console.ReadLine());
//                DivisionByZero(i);
//            }
//            catch(Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static void DivisionByZero(int i)
//        {
//            int j = 0;
//            int k = i / j;
//            Console.WriteLine();
//        }
//    }
//}

namespace ThrowExAndThrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                DivisionByZero(i);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void DivisionByZero(int i)
        {
            int j = 0;
            int k = i / j;
            Console.WriteLine();
        }
    }
}