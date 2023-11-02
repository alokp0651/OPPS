using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[5];//<<----------size limit
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            //array[5] = 6;
            //array[6] = "alok"; //<--------limitation of array strongly type;

            Console.WriteLine(array[0]);


            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Happy");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
           
            Console.ReadLine();


        }
    }
}
