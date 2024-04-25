namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = "Anna has apples";
            var wordNo = Extensions.WordCount(myString);
            int wordNoFromExtension = myString.WordCountExtension();

            int a = 0;
            int b = 10;
            if (a.GreaterThan(b))
            {
                Console.WriteLine("A");
            }

            var myTime = DateTime.Now;
            Console.WriteLine(myTime.RoundToHalfHour());
            myTime = new DateTime(myTime.Year, myTime.Month, myTime.Day, 15, 45, 00);
            Console.WriteLine(myTime.RoundToHalfHour());

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //count all odd numbers

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    count++;
                    //count = count + 1;
                }

            }
            Console.WriteLine($"The number of odd numbers is: {count}");

            var oddNumbers = numbers.Count(x => x % 2 == 1);
            var greaterThan6 = numbers.Count(item => item >= 6);

            Func<int, bool> intFn = (x) => x < 10;

            var lessThanTen = numbers.Count(x => intFn(x));

            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "John", LastName = "Doe", City = "New York", Country = "USA" },
                new Person { FirstName = "Jane", LastName = "Smith", City = "Los Angeles", Country = "USA" },
                new Person { FirstName = "David", LastName = "Brown", City = "London", Country = "UK" },
                new Person { FirstName = "Emily", LastName = "Johnson", City = "Toronto", Country = "Canada" },
                new Person { FirstName = "Michael", LastName = "Lee", City = "Sydney", Country = "Australia" }
            };

            var peopleNoInUsa = people.Count(x => x.Country == "USA");

            var peopleInTwoWordsCity = people.Where(x => x.City.WordCountExtension() >= 2).ToList();

            var orderedByCountry = people
                .OrderBy(x => x.Country)
                .OrderByDescending(x => x.City)
                .ToList();
        }
    }
}
