using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    public enum Fur
    {
        //white, black, red, maroon
        White,
        Black,
        Red,
        Maroon
    }

    public enum EyeColor
    {
        // red, black, blue
        Red,
        Black,
        Blue
    }

    public enum Gender
    {
        Female,
        Male
    }

    public class Rabbit : Mammal
    {
        private DateTime birthDate;
        //private readonly Fur furColor;


        //public Fur FurColor
        //{
        //    get { return furColor; }
        //    private set { furColor = value; }
        //}

        public Fur FurColor { get; private set; }

        public EyeColor EyeColor { get; private set; }

        public Gender Gender { get; private set; }

        public DateTime BirthDate
        {
            get { return birthDate; }
        }

        public string ExactAge
        {
            get
            {


                var years = DateTime.Now.Year - birthDate.Year;
                //int years = now.AddYears(-birthDate.Year).Year;
                // int months = now.AddMonths(-birthDate.Month).Month;//to investigate

                int months = DateTime.Now.Month - birthDate.Month;
                return $"The Age is {years} and {months} months";
            }
        }

        public string GetAge()
        {
            var years = DateTime.Now.Year - birthDate.Year;
            TimeSpan age = DateTime.Now - birthDate;
            //int years = age.Days / 365;
            int months = DateTime.Now.Month - birthDate.Month;
            return $"{years} years and {months} months";
        }

        //public string Age
        //{
        //    get
        //    {
        //        TimeSpan age = DateTime.Now - birthDate;
        //        int years = age.Days / 365;
        //        int months = (age.Days % 365) / 30;
        //        return $"{years} years and {months} months";
        //    }
        //}
        public string AgeCorrect
        {

            get
            {
                var currentDate = DateTime.Now;
                var age = currentDate.Year - birthDate.Year;
                var ageMonth = currentDate.Month - birthDate.Month;
                if (ageMonth < 0)
                {
                    ageMonth += 12;
                }
                return $"The exact age is: {age} and {ageMonth}.";
            }
        }

        public Rabbit()
        {

        }

        public Rabbit(DateTime birthDate, EyeColor eyeColor, Fur furColor, Gender gender)
        {
            this.birthDate = birthDate;
            EyeColor = eyeColor;
            FurColor = furColor;
            //  this.furColor = furColor;
            Gender = gender;
        }

        public override void Eat()
        {
            Console.WriteLine("I'm eating carrots!");
        }

        public override string ToString()
        {
            var myRabbitInfo = $"Age :{this.ExactAge}, EyeColor:{this.EyeColor}, and I am  {this.Gender}";
            base.ToString();
            return myRabbitInfo;
        }

    }
}
