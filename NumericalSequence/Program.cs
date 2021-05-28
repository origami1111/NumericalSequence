using System;

namespace NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController consoleController = new ConsoleController();
            consoleController.Start();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
