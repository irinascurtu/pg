namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            //var line = Console.ReadLine();

            ////var myNumber = int.Parse(line);
            //var success = int.TryParse(line, out int myNumber2);
            //if (success)
            //{
            //    //execute code

            //}
            //else
            //{
            //    Console.WriteLine("Sorry, I can't transform to a number");
            //}

            var firstNumber = ReadFromConsole();
            var secondNumber = ReadFromConsole();

            Console.ReadKey();
            //Console.WriteLine("Hello, World!");
            //var firstNumber = 2;
            //var secondNumber = 3;

            //Add();

            //var sum = Add(2, 4);
            //Add(2, 4);
            //Console.WriteLine(sum);
            //Console.WriteLine(Add(2, 4));


            //Add(firstNumber, secondNumber);
            //Add(firstNumber * 5, secondNumber * 2);
            //Add(2.3m, 4m);
            //DisplayNumbers();
            //DisplayNumbers(0, 10);
            //DisplayNumbers(end: 120, start: 110);
            //DisplayNumbers(start: 110, end: 120);

            //Console.WriteLine(ComputeSum(2, 4, 5, 6));
            //var sum2 = ComputeSum(2, 4);
            //Console.WriteLine(sum2);
        }

        static int ReadFromConsole()
        {
            var line2 = Console.ReadLine();
            var success2 = int.TryParse(line2, out int myNumber3);
           
            float.TryParse(line2, out float myNumber4);
            decimal.TryParse(line2, out decimal myNumber5);

            if (success2)
            {
                //execute code
                return myNumber3;
            }
            else
            {
                Console.WriteLine("Sorry, I can't transform to a number");
            }

            return myNumber3;
        }

        static void Add()
        {
            Console.WriteLine(2 + 3);
        }

        //static void Add(int a, int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //}

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Add(decimal a, decimal b)
        {
            Console.WriteLine(a + b);
        }

        static void DisplayNumbers(int start = 0, int end = 100)
        {
            Console.WriteLine($">>>> I got :{start}-{end}");
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("<<<");
        }

        static int ComputeSum(params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
                //sum=sum+item;
            }
            return sum;
        }
    }
}
