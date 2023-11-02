using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "interview";
            string str2 = "alok";
            str1 = str1+str2;  //<<--------------this will create a new instance thats why sting ones created could'nt be modify (immutable)
            Console.WriteLine(str1);



            StringBuilder sb = new StringBuilder("SBInterview");
            string str3 = "happy";
            sb.Append(str3);//<<-------------it is not creating new instance
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
