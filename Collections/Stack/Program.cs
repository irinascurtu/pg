namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> bookNames = new Stack<string>();
            bookNames.Push("C#, hands-on");//0
            bookNames.Push("Ana Karenina");//1
            bookNames.Push("javascript for dummies");//2
            bookNames.Push("From zero to hero");//3

            Console.WriteLine(bookNames.Peek());

            while (bookNames.Count > 0)
            {
                var currentBook = bookNames.Pop();
                Console.WriteLine($"The current book is :{currentBook}");
            }

            Queue<string> lunchQueue = new Queue<string>();
            lunchQueue.Enqueue("Maria");
            lunchQueue.Enqueue("Gigi");
            lunchQueue.Enqueue("John");
            lunchQueue.Enqueue("Gheorghe");

            Console.WriteLine(lunchQueue.Peek());

            while (lunchQueue.Count > 0)
            {
                var nextInLine = lunchQueue.Dequeue();
                Console.WriteLine($"The next person in line is: {nextInLine}");
            }


        }
    }
}
