using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricClass
{
    public class Program<T>
    {
        public static bool Areequal(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        static void Main(string[] args)
        {
            //bool equals = Program<int>.Areequal(1, 2);
            bool equals = Program<string>.Areequal("Interview", "alok");
        }
    }
}
