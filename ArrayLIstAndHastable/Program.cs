using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLIstAndHastable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Happy");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

            Hashtable ht = new Hashtable();
            ht.Add("123", "Alok");
            ht.Add("124", "Sonam");
            foreach (KeyValuePair<string,string> ht in arrayList)
            {
                Console.WriteLine(ht);
            }


        }
    }
}
