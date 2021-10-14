using System;

namespace Demo_LatestLangFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Person CFO = NewPerson();
            //CFO.Fname = "ice";
           // CFO.Lname="cream";
                
            NewPerson CEO = new NewPerson();
            CEO.FirstName = "sravs";
            CEO.LastName = "Rav";

            Coordinates India = new Coordinates(120, 220);
            Console.WriteLine("Indian Coordinates are" + India.x + India.y);
            Console.WriteLine(MyEnum.green + "is my good color");
         
        }
    }
    public record Person(string Fname, string Lname);
    public record Person1
    {
        public string Firs_tName { get; init; } = default!;

        public string LastName { get; init; } = default!;


    }

    public record NewPerson
    {
        public string FirstName { get;  set; } =default!;

        public string LastName { get;  set; } = default!;


    }
}
