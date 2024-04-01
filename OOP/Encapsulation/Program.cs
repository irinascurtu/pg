namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("32323232", "Gigi", "Davidescu");
            Console.WriteLine(person.CNP);
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            // person.LastName = "dsadsa"; not possible
            Console.WriteLine(person.Salary);
            person.GetMarried("Testarescu");
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Salary);

            //person.Salary = 1010101;
            person.IncreaseSalary();
            person.IncreaseSalary();
            person.IncreaseSalary();
            person.IncreaseSalary();
            person.IncreaseSalary();
            Console.WriteLine(person.Salary);

        }
    }
}
