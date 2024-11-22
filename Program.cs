using System;
using System.Net;
using ClassLibrary1;

namespace Practice_Theme_3__4
{
    internal class Program
    {
        static void Main()
        {
            Greetings greetings = new Greetings();
            greetings.PrintGreeting();
            greetings.PrintGoodbye();

            Methods methods = new Methods();
            int sum = methods.Add(5, 10);
            Console.WriteLine(sum);

            string greeting = methods.GetGreeting("Алексей");
            Console.WriteLine(greeting);

            bool isEven = methods.IsEven(4);
            Console.WriteLine(isEven);
        }
    }
}
