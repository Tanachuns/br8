using System;

namespace CalculationService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new();
            //1
            tree.Print(4);
            Console.WriteLine("==========");
            tree.Print(5);
            Console.WriteLine("==========");
            tree.Print(6);
            Console.WriteLine("==========");
            tree.Print(0);
            Console.WriteLine("==========");

            //2
            // Exchanger exchanger = new();
            // exchanger.PrintConvert(100000, "WON");

            //3
            // Car car = new Car();
            // car.PrintDistance(-10);
        }
    }
}