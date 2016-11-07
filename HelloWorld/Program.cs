using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }


        /// <summary>
        ///  Method to display simple text message
        /// </summary>
        /// <returns></returns>
        public static string CreateMessage()
        {
            return "Hello World";

        }

    }
}
