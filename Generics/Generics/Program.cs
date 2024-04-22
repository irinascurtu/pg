namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Swap(2, 4);
            Swap<int>(3, 4);
            Swap<string>("lalal", "sss");

            Box<int> myIntBox = new Box<int>(2);
            Console.WriteLine(myIntBox.ToString());

            CustomList<string> customList = new CustomList<string>();
            customList.Add("a");
            customList.Add("b");
            customList.Add("c");

            var item = customList.Remove(1);

            var maxItem = customList.Max();
            var contains = customList.Contains("a");
            // CustomList<Box<int>> myBox = new CustomList<Box<int>>();


            var scale = new Scale<int>(5, 10);
            Console.WriteLine(scale.GetHeavier());

            var scale2 = new Scale<string>("Man", "Woman");
            Console.WriteLine(scale2.GetHeavier());
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
