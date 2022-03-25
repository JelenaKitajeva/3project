using System;

namespace PersonalityTestSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favorit color?");
            string userImput = Console.ReadLine().ToLower();
            switch (userImput)
            {
                case "red":
                    Console.WriteLine("You are soromantic");
                    break;
                case "blue":
                    Console.WriteLine("You are workaholic");
                    break;
                case "green":
                    Console.WriteLine("You care about the environment");
                    break;
                default:
                    Console.WriteLine($"You are {userImput} unicorn.");
                    break;
            }
            
            Console.WriteLine("Have a nice day!"); 
        }
    }
}
