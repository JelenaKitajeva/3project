using System;

namespace Gradingif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your exam result:");
            char userImput = Convert.ToChar(Console.ReadLine().ToUpper());
            if (userImput == 'A')
            { Console.WriteLine("Outstanding"); }
            else if (userImput == 'B')
            { Console.WriteLine("Superior"); }
            else if (userImput == 'C')
            { Console.WriteLine("Good"); }
            else if (userImput == 'D')
            { Console.WriteLine("Satisfactory"); }
            else if (userImput == 'E')
            { Console.WriteLine("Low Pass"); }
            else if (userImput == 'F')
            { Console.WriteLine("Failure"); }
            else
            {
                Console.WriteLine($"Exam result {userImput} is not right!.");
            }

            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
