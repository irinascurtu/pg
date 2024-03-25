using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = "Hello world!";
            Console.WriteLine(myFirstString);

            int myNumber = 43;
            Console.WriteLine(myNumber);

            string myNumberAsString = myNumber.ToString();//converts to string
            Console.WriteLine(myNumberAsString);

            //it won't do any conversion since it's already a string
            myNumberAsString = myFirstString.ToString();

            string firstName = "Gigi";
            string lastName = "Devinson";
            string fullName = firstName + " " + lastName;

            string fullNameWithConcat = String.Concat(firstName, " ", lastName);

            int indexOfFirstLetter = fullNameWithConcat.IndexOf("on", 5);

            Console.WriteLine(fullName);
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine($"{firstName} {lastName}");//string interpolation


            //extracting substrings
            string firstNameExtracted = fullNameWithConcat.Substring(0, 4);

            //"C:/Holiday/2025/1/nice_pics.png";
            //"C:/Holiday/2025/1/nice_pics.webp";
            string path = "C:/Holiday/2025/nice_pics.png";
            //extract the file extension
            // look for special chars 
            // last 3 chars 
            var indexOfDot = path.IndexOf(".");
            string extension = path.Substring(indexOfDot + 1);

            // extract the fileName
            // LastIndexOf("/")
            int lastSlash = path.LastIndexOf("/");
            int substringLength = indexOfDot - lastSlash - 1;
            string fileName = path.Substring(lastSlash + 1, substringLength);

            string a = "a";
            string b = "b";

            if (string.Compare(a, b) < 0)
            {
                //in lexicographical order, a should be to the left of b
                //-1 a < b,  
                //0  a equals b
                // 1 a > b

            }
            // string fileName = path.Substring(path.LastIndexOf("/") + 1, indexOfDot - path.LastIndexOf("/") - 1);

            string listOfBeers = "Ursus, Ciuc, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(',', ' ', '.');
            foreach (var beer in beers)
            {
                if (!string.IsNullOrEmpty(beer))
                {
                    Console.WriteLine(beer.ToUpper());

                }
            }

            string mySpacedString = " this is a string     ";

            Console.WriteLine(mySpacedString.TrimStart());
            Console.WriteLine(mySpacedString.TrimEnd());
            Console.WriteLine(mySpacedString.Trim());

            string myFunnyString = "-++++this is a string++++  ----";
            Console.WriteLine(myFunnyString.Trim('+', '-'));

            //var stopWatch=new Stopwatch();
            //string myCoolString = "Counting bottles: ";
            //stopWatch.Start();
            //for (int i = 0; i < 10000; i++)
            //{
            //    myCoolString += i.ToString();
            //    Console.WriteLine(myCoolString);
            //}
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.Elapsed);

            StringBuilder stringBuilder = new StringBuilder();
            var stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            stringBuilder.Append("Counting bottles: ");

            for (int i = 0; i < 10000; i++)
            {
                stringBuilder.Append(i.ToString());
                Console.WriteLine(i);
            }
            Console.WriteLine(stringBuilder.ToString());
            stopWatch2.Stop();
            Console.WriteLine(stopWatch2.Elapsed);

            double d = 0.375;
            string infoToDisplay = d.ToString("P2");
            string myFormattedString = String.Format("{0,10:F5}", d);//F- fixed point, real numbers
            Console.WriteLine("{0,10:F5}", d);

            var myDate = DateTime.Now;
            var myFormattedDate = String.Format("{0:d.MM.yyyy HH:mm}", myDate);

            CultureInfo culture = new CultureInfo("ro-RO");
            Console.WriteLine(myDate.ToString("d", culture));
            //3 dates on 3 different cultures

            string myDate2 = "20.03.2024";
            DateTime myParsedDate = DateTime.ParseExact(myDate2, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }
}
