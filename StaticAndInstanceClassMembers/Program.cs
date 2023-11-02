namespace StaticAndInstanceClassMembers
{
    class circle
    {
        //static float _PI = 3.14F; //state
        static float _PI;
        int _Radius;                            //<<-----------if static keyword mentioned in front of class memebers or variables it called as static member otherwise all are instance member  static field hold a memory at once and used by multiple instance of and object.

        static circle()   //<<<----Static constructor does not alllow access modifier ,  Static constructor called before instance constructor and static constructor called at once no matters how many instances you create.
        {
            circle._PI = 3.14F;//<<<<<----- Satic  members are invoked using class name
        }



        public circle(int Radius) //<-----Parameterised constructor.
        {
            this._Radius = Radius;
        }

        public float CalculateArea() //Behaiviour
        {
            //return this._PI * this._Radius * this._Radius;    //<----as we create _PI static the  "this._PI" will start showing you a error beacuse this is used to called Instance field Not static.
            return _PI * this._Radius * this._Radius;
           
        }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            circle C1 = new circle(5);
            float Area = C1.CalculateArea();
            Console.WriteLine("Area={0}",Area);

            circle C2 = new circle(6);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("Area={0}", Area2);

        }
    }
}



//Types of constructor
//1.Parameterised constructor
//2.Default constructor
//3.static constructor : used to inintialize the static field.