namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> grades = new Dictionary<string, int>();

            grades.Add("Maria", 9);
            grades.Add("gigi", 4);
            grades.Add("Misu", 7);
            grades.Add("John", 9);

            Console.WriteLine(grades["Maria"]);

            var keys = grades.Keys.ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                string currentKey = keys[i];
                int currentValue = grades[currentKey];

                Console.WriteLine($"Key is {currentKey}, the value is: {currentValue}");
            }



            //complex with int and String, declaration + init
            Dictionary<int, List<string>> complexDict = new Dictionary<int, List<string>>();
            List<string> names = new List<string>()
            {
               "Gigi",
                "Maria"
            };

            complexDict.Add(1, names);

            Dictionary<int, List<string>> complexDict2 = new Dictionary<int, List<string>>()
            {
                { 1, new List<string>() {"Maria", "David"}},
                { 4, new List<string>() {"Ion", "Gigi"}},

            };


            foreach (int key in complexDict2.Keys)
            {
                var currentValues = complexDict2[key];
                foreach (string value in currentValues)
                {
                    Console.WriteLine(value);
                }

            }
        }
    }
}
