namespace Type_Converssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 100;
            //float f = i;                           // Implicit conversion
            //Console.WriteLine("i = {0}",i);


            //explicit conversion 
            float f = 123.45f;
             int i = (int)f; // data will get lost in type cast operator

            //int i = Convert.ToInt32(f);   // here we are using convert class method
            Console.WriteLine("i = {0}", i);



            //string strNum = "100tg";
            //int ConverttoInt = int.Parse(strNum); // this Parse() will show exception because of 100tg
            //Console.WriteLine(ConverttoInt);


            string strNUm = "100tg";
            int Result = 0;

            bool IsConversionSuccesfull =  int.TryParse(strNUm, out Result);

            if (IsConversionSuccesfull )
            {                                                                                  //this will solve above problem so we use TryParse to Catch the exception  
                Console.WriteLine(Result);
            }
            else {
                Console.WriteLine("Please enter valid number");
                    
            }
            


        }
    }
}