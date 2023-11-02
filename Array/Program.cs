namespace Array
{
    internal class Program
    {    // array is the collection of simliar datatype
        static void Main(string[] args)
        {
            int[] EvenNum = new int[3];

            EvenNum[0] = 0; // Arrays are  of strongly typed  if we assigned EvenNum[0] ="name" <<<--- as string value then it will show error because EvenNum[0] is of integer type.
            EvenNum[1] = 2;
            EvenNum[2] = 4;
            EvenNum[3] = 6; //<<<<<<<<------------see size of the araay assigned "3" at line no 7 so if we add one more data in array i.e EvenNum[3] it will givw you a runtime error this is the disadvantage of array(runtime error) and it will throw an indexoutofrange exception.

            Console.WriteLine(EvenNum[1]);
            //Console.WriteLine(EvenNum[1]); <<---this will also give runtime exception
        }
    }
}