using OOP.Dogs;
using OOP.Fly;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beagle beagle = new Beagle("Loona", "jumps");
            beagle.Sleep();
            beagle.DoTrick();
            beagle.Bark();
            beagle.Eat();


            //Bird bird = new Bird();
            
            //Plane plane = new Plane();

            //IFlyable flyableObject = new PaperAiplane();
            //flyableObject.Fly();

            //flyableObject = bird;
            //flyableObject.Fly();

            //flyableObject = plane;


        }
    }
}
