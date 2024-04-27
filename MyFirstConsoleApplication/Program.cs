using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Chais Chang";
            string location = "Springville Utah USA";

            Console.WriteLine($"Hello, My name is {myName}.");
            Console.WriteLine( "I am from " + location + "." );

            Console.WriteLine($"{ Environment.NewLine}What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"{Environment.NewLine}Hi there {name}.");

            DateTime thisDateTime = DateTime.Now;
            DateTime christmasDate = new DateTime(2024, 12, 25, 0, 0, 0);
            TimeSpan interval = christmasDate - thisDateTime;

            Console.WriteLine($"{Environment.NewLine}Today is: {thisDateTime:d}.");
            Console.WriteLine($"{Environment.NewLine}Number of days until Christmas: {interval.Days}.");

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
