using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorit color?");
            string userImput = Console.ReadLine().ToLower();
            if (userImput == "red")
            { Console.WriteLine("You are so romantic"); }
            else if (userImput == "blue")
            { Console.WriteLine("You are workaholic"); }
            else if (userImput == "green")
            { Console.WriteLine("You care about the environment"); }
            else { Console.WriteLine($"You are {userImput} unicorn."); }
            Console.WriteLine("Have a nice day!");
        }
    }
}
