using System.ComponentModel;

namespace MethodParameters
{

    //4 type of method parameters 
    //    1.Value
    //    2.Refrence
    //    3.Out
    //    4.Parameters Arrays
        
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //Simplemethod(i);  // <<< ----value example
            //Console.WriteLine(i);

            //int i = 0;
            //Simplemethod(ref i);   //<<<<<<--- ref example
            //Console.WriteLine(i);


            //int Total = 0;     //<<<<------Out Parameter
            //int Product = 0;
            //Calculate(10, 20, out Total, out Product);
            //Console.WriteLine("Sum ={0} && Product ={1}", Total, Product);

            int[] Number = new int[3];

            Number[0] = 1;
            Number[1] = 2;
            Number[2] = 3;

            //PramsMethods();  // if we use "params" keyword in method parameter this line will not show error

            PramsMethods(Number);

            //PramsMethods(1, 2, 3, 4);   //< --------------this is method Argument ehen we pass a value to the method parameter


        }

        // passing a parameter By Value 

        //public static void Simplemethod(int j)     //<<<<---------pointing to diffrent memory location
        //{
        //    j = 101;
        //}

        // passing parameter By refrence

        //public static void Simplemethod(ref int j)      //<<<<---------pointing to same memory location thats why value changed
        //{
        //    j = 101;
        //}


        //out parameter 

        //public static void Calculate(int FN, int SN, out int Sum, out int Product) // Void is used because out parameter dont have return type
        //{
        //    Sum = FN + SN;
        //    Product = FN * SN;

        //}

        //Parameters Arrray

        public static void PramsMethods(params int[] Number) //Param keyword should be the last one in method declaration and only params keywords used in method declaration 
        {
            Console.WriteLine("There are {0} Elements", Number.Length);

            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
        }
    }
}