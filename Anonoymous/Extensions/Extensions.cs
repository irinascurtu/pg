using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static int WordCount(string myString)
        {
            //"ana has apples"
            string[] words = myString.Split(' ');
            int noOfWords = words.Length;
            return noOfWords;
        }

        public static int WordCountExtension(this string myString)
        {
            int noOfWords = myString.Split(' ').Length;
            return noOfWords;
        }

        public static bool GreaterThan(this int a, int b)
        {
            return a > b;//a.GreaterThan(b)
        }


        public static DateTime RoundToHalfHour(this DateTime input)
        {
            //14:01- 14:29 -> 14:00
            //14:30- 14:59 -> 15:00
            DateTime dateToReturn = new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0);
            if (input.Minute == 0)
            {
                return input;

            }

            if (input.Minute >= 1 && input.Minute < 30)
            {
                return dateToReturn.AddMinutes(30 - input.Minute);
            }
            //else
            //{
            return dateToReturn.AddMinutes(60 - input.Minute);
            //}


            // return dateToReturn;
        }

    }
}
