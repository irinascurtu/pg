namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine(list.Count);
            list.Add("C#");
            list.Add("javascript");

            List<string> secondList = new List<string>() { "Python", "Ruby", "sfsfsf" };
            secondList.AddRange(list);
            Console.WriteLine(secondList.Count);//5

            for (int i = 0; i < secondList.Count; i++)
            {
                Console.WriteLine(secondList[i]);
            }

            foreach (string s in secondList)
            {
                Console.WriteLine(s);
            }

            secondList.Remove("C#");
            secondList.Reverse();
            secondList.Sort();
            var hasCSharp = secondList.Contains("C#");


            string[] firstArray = new string[] { "C#", "javascript" };

            string[] secondArray = new string[] { "Python", "Ruby", "sfsfsf" };
            var arrayLength = secondArray.Length;//3

            string[] finalArray = new string[firstArray.Length + secondArray.Length];
            for (int i = 0; i < finalArray.Length; i++)
            {
                if (firstArray.Length <= i)
                {
                    finalArray[i] = firstArray[i];
                }

            }

            //arrayString[4] = "ss";
            //secondList.Add("Python");
            // secondList.Add("Ruby");

            var obj1 = new Person("Gigi", "Dev", 2);
            var obj2 = new Person("Gigi", "QA", 30);
            var obj3 = new Person("Mircea", "Pescuiescu", 60);

            ICitizen obj1SSN = obj1;
            ICitizen obj1SSN1 = new Person("Person", "SSN", 20); ;
            //obj1SSN.SSN


            List<Person> people = new List<Person>();
            people.Add(obj1);
            people.Add(obj2);
            people.Add(obj3);




            foreach (Person item in people)
            {
                //operations
                Console.WriteLine($"{item.LastName}, {item.FirstName}, {item.Age}");
            }

            Martian martian = new Martian();

            List<ICitizen> ssns = new List<ICitizen>();

            ssns.Add(obj1);
            ssns.Add(obj2);
            ssns.Add(obj3);
            ssns.Add(martian);

            foreach (ICitizen item in ssns)
            {
                Console.WriteLine(item.SSN);
            }
        }
    }
}
