namespace Method
{
    //methods(Function) are extremely useful because they alllow you to define your logic once and use it at many places.

    //[attributes]
    //access-modifiers return-type method-name(parameters)
    //{
    //    Method body
    //}

    // 1. return typ will bw any valid datatype or void.
    // 2.parameters are optional.
    // 3. void method returntype do not return any thing.

    internal class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();   // invoking the instant method by creating the instance of the class using new keyword .
            // p.EvenNum();             

            //Program.EvenNum(); //<<<<--------- invoking static method here we have to use directly the name of the class.

            Program.EvenNum(30); // providing target as parameter

            Program p = new Program();
            int sum =   p.Add(30, 40);
            Console.WriteLine("sum ={0}",sum);
            
        }

        //public void EvenNum()  // <----this is the instant method  because we can invoke this method by creating instance of the class.
        //{
        //    int start = 0;

        //    while(start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 2;
        //    }
        //}


        //public static void EvenNum()  // <----this is the static method 
        //{
        //    int start = 0;

        //    while (start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 2;
        //    }
        //}

        public static void EvenNum(int target)  // <----this is the static method with taking parameter
        {
            int start = 0;

            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public int Add(int Fn, int Sn)
        {
            return Fn + Sn;  // since it is a integer return type instance method it will return integer value
        }



    }
}