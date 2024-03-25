namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] ints;
            ints = new int[3];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;

            //ints[4] = 10; will throw an exception
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Sunday", "Friday", "Thursday" };
            string[] newDays = new string[7];

            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                newDays[i] = daysOfTheWeek[i];
            }

            Console.WriteLine(daysOfTheWeek[0]);

            ints[1] = 1;

            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }

            int index = 0;
            while (index < daysOfTheWeek.Length)
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            index = 0;
            do
            {
                Console.WriteLine(daysOfTheWeek[index]);
                index++;

            } while (index < daysOfTheWeek.Length);


            foreach (var item in daysOfTheWeek)
            {
                Console.WriteLine(item);
            }

            int a = 5;
            string[] myArrayCopy = daysOfTheWeek;
            string[] myArrayCopy2 = myArrayCopy;
            string[] myArrayClone = (string[])daysOfTheWeek.Clone();

            // int[,] myMatrix = new int[2, 2];
            int[,] myMatrix ={
                { 1, 2},
                {2, 4 }
            };

            Console.WriteLine(daysOfTheWeek);

            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write(myMatrix[i,j]);
                }
                Console.Write("\n");
            }

            int[,] myMatrix2 = new int[2, 2];
            myMatrix2[0, 0] = 1;
            myMatrix2[0, 1] = 2;
            myMatrix2[1, 0] = 2;
            myMatrix2[1, 1] = 4;


            Console.WriteLine("Please give an array size:");
            int arraySize = int.Parse(Console.ReadLine());

            var myArrayFromConsole = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            }


        }
    }
}
