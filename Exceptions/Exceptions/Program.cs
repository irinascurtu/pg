namespace Exceptions
{
    using System.Collections;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            try
            {
                //  CauseFormatException();//the sensitive code
            }
            catch (FormatException ex)//specific
            {

            }
            catch (ArgumentException ex)//specific
            {

            }
            catch (Exception ex)//generic one
            {
                Console.WriteLine(ex.Message);
                //  throw;//keep the stack trace
                // throw ex;//this changes the stack trace!! Don't do this!!!!!
            }
            finally
            {
                Console.WriteLine("Finally here: I'm always executing, I'm final!");
            }


            try
            {

            }
            finally
            {

            }
            //equivalent to

            //using ()
            //{

            //}


            try
            {
                Song mySong = new Song();
                mySong.Name = "AbC";
                mySong.Artist = "Devinson";
                mySong.Minutes = 30;
                mySong.Seconds = 4;
            }
            //catch (InvalidArtistNameException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (InvalidMinutesException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (InvalidSecondsException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            //catch (InvalidSongException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
                        //catch (InvalidSongException ex) when (ex is InvalidMinutesException)
                        //{
                        //    Console.WriteLine(ex.Message + typeof(InvalidMinutesException));
                        //}
                        //catch (InvalidSongException ex) when (ex is InvalidArtistNameException)
                        //{
                        //    Console.WriteLine(ex.Message + typeof(InvalidArtistNameException));
                        //}
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        public static void CauseFormatException()
        {
            //throw new StackOverflowException("This is me!");
            //string a = "this is a string";
            //Int32.Parse(a);
        }
    }
}
