using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricMethod
{
    public class Program
    {

        public static bool Areequal<T>(T value1,T value2)
        {
            return value1.Equals(value2);
        }
        static void Main(string[] args)
        {
           // bool equals = Program.Areequal<int> (1, 2);
            bool equals = Program.Areequal<string> ("Interview", "alok"); // we made it typre independent
            Console.WriteLine (equals);
        }
    }
}
