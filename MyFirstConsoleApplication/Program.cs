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
            var myName = "Chais Chang";
            var location = "Springville Utah USA";

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

            Console.WriteLine($"{Environment.NewLine}This next part of the program helps you find material totals for ordering a new double pain window");
            Console.WriteLine("The information provided will help us to estamate costs for the window by giving you total glass area and total wood length");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine($"{Environment.NewLine}What is the width of the window in meeters?{Environment.NewLine}(Please give your answer in digits only ex. 2.25) ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine($"{Environment.NewLine}What is the height of the window in meeters?{Environment.NewLine}(Please give your answer in digits only ex. 1.25) ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
