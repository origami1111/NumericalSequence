using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            uint m;

            Console.Write("Введите длину ряда: ");
            n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите значение минимального квадрата: ");
            m = Convert.ToUInt32(Console.ReadLine());

            NumericalSequence numericalSequence = new NumericalSequence(n, m);
            numericalSequence.printRange();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
