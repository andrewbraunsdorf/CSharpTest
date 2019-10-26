using System;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"Hello World!\"");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter \"Hello World!\"");
            } else if (input == "Hello World!")
            {
                Console.WriteLine("Congratulations!!! Good Bye Now");
            }
            else
            {
                Console.WriteLine("Please enter \"Hello World!\"");
            }
        }
    }
}
