namespace MyFirstConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hey you!");
            string firstName = "Irina";
            string lastName = "Dev";

            string fullName = firstName + " " + lastName;
            var firstChar = fullName[0];

            Console.WriteLine(fullName);

            float myFloat = 3.141592653589793238F;
            var myDouble = 3.141592653589793238;
            decimal myDecimal = 3.141592653589793238M;

            Console.WriteLine("Float PI is: {0}", myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);

            double a = 0.66F;
            double b = 0.34F;
            if (a + b == 1)
            {
                Console.WriteLine("equals 1");
            }

            bool isRight = false;
            if (isRight)
            {
                Console.WriteLine("IsRight");
            }

            Console.WriteLine(firstName);

        }
    }
}
