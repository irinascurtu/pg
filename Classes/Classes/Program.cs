using System.ComponentModel.DataAnnotations;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dog dalmatian = new Dog("Max", Breed.Dalmatian);
            Dog beagle = new Dog("Pat", Breed.Beagle);

            beagle.Bark();
            beagle.Eat();

            beagle.Name = "Spot";
            Console.WriteLine(beagle.Name);
            Console.WriteLine(beagle.OwnerName);
            var dog = new Dog();

            Breed myDogsBreed = Breed.Husky;
            var myIntRepresentation = (int)myDogsBreed;
            Breed breed1 = (Breed)5;


            var myLevel = Level.Beginner;
            string level = "";

            if(myLevel == Level.Beginner)
            {
                //
            }

            if (myLevel == Level.Advanced)
            {
                //
            }

            var whatLevel = (int)myLevel;
            // var myDogBreed = "husky";//Husky

            var breed = Breed.Husky;
            Console.WriteLine(Dog.numberOfInstances);

            //var dogOwner = Dog.Owner;
            //beagle.Owner
            // beagle.Name = "Spot";
            Console.WriteLine(Dog.GetInstanceNumber());

            // var dogOwner = Dog.Owner;

            Person myPerson= new Person("Gigi","Dev", 1989, Gender.Male);
            var age = myPerson.Age;
        }
    }
}
