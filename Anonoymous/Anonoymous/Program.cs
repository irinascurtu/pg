using System.Drawing;

namespace Anonoymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int val1 = 0;
            Example1(ref val1);


            int val2;
            Example2(out val2);


            var myCar = new
            {
                Make = new
                {
                    Model = "Fabia",
                    LaunchedYear = 2020
                },
                ProductionYear = "2024",
                Color = "red"
            };

            Console.WriteLine(myCar.Make.Model);
            Console.WriteLine(myCar.Color);


            var cars = new[] {
                new {
                    Make = new
                    {
                        Model = "Fabia",
                        LaunchedYear = 2020
                    },
                    ProductionYear = "2024",
                    Color = "red"
                },

                new{
                    Make = new
                    {
                        Model = "Octavia",
                        LaunchedYear = 2020
                    },
                ProductionYear = "2022",
                Color = "red"}
             };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].Color);
                Console.WriteLine(cars[i].Make.Model);
            }

            var people = new List<Person>();
            people.Add(
                new Person()
                {
                    Age = 30,
                    HairColor = "red",
                    Profession = "Teacher",
                    ShoeSize = 42
                });
            people.Add(
                 new Person()
                 {
                     Age = 30,
                     HairColor = "black",
                     Profession = "IT dev",
                     ShoeSize = 35
                 });


            var ageProfession = people.Select(x => new
            {
                Age = x.Age / 5,
                Height = x.ShoeSize + 5
            });


            var secondListOfCars = cars;

        }

        public static void Example1(ref int n)
        {
            n = 1;
        }

        public static void Example2(out int n)
        {
            n = 10;
        }

        public static int Example3(int n)
        {
            return n = 10;
        }
    }
}
