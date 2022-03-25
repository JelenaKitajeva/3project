using System;

namespace GreadingSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam result:");
            char userImput = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (userImput)
            {
                case 'A':
                    Console.WriteLine("Outstanding");
                    break;
                case 'B':
                    Console.WriteLine("Superior");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                     break;
                case 'D':
                    Console.WriteLine("Satisfactory");
                    break;
                case 'E':
                    Console.WriteLine("Low Pass");
                    break;
                case 'F':
                    Console.WriteLine("Failure");
                    break;
                default:
                    Console.WriteLine($"Exam result {userImput} is not right!.");
                    break;
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
