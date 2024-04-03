namespace Rabbit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit myRaabit = new Rabbit();
            Console.WriteLine( myRaabit.ExactAge);


            Rabbit myCoolRabbit = new Rabbit(new DateTime(2023, 4, 3), EyeColor.Blue, Fur.White, Gender.Male);
            Console.WriteLine(myCoolRabbit.ExactAge);
            Console.WriteLine(myCoolRabbit.BirthDate);
            Console.WriteLine(myCoolRabbit.AgeCorrect);

            Rabbit myCoolRabbit2 = new Rabbit(new DateTime(2022, 11, 3), EyeColor.Red, Fur.Black, Gender.Female);

            Rabbit[] rabbits = new Rabbit[2];
            rabbits[0] = myCoolRabbit;
            rabbits[1] = myCoolRabbit2;

            for (int i = 0; i < rabbits.Length; i++)
            {
                Console.WriteLine(rabbits[i].ToString());
            }

            DataAccess dataAccess = new DataAccess();
        }
    }
}
