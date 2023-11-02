using System.Net.Http.Headers;

namespace Nullable_type
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            string Name = null; // Reference will be a Nullable type here as Value type will never be a nullable type
            //int i = null; // Error
            int? k = null; // to make value type nullable we have to just put ?



            bool? AreyoMajoor = null;
            if (AreyoMajoor == true)
            {
                Console.WriteLine("User is major");
            }
            else if (!AreyoMajoor.Value) //We can use like this or (AreyoMajoor == false)  is also correct
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("User did not question the answer");
            }


            int AvailableTickets;
            int? TicketsOnSale = 100;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale; // we are forcing to convert a nullable datatype to not nullable datatype
            }


            //int? TicketsOnSale = 100;

            //int AvailableTickets = TicketsOnSale ?? 0;    <<<<<---Shortway

            Console.WriteLine("Available Tickets={0}", AvailableTickets);  // easy way
        }
    }
}