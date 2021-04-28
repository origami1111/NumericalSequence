using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequence
{
    class NumericalSequence
    {
        private uint n;
        private uint m;

        public NumericalSequence() { }
        public NumericalSequence(uint n, uint m)
        {
            this.n = n;
            this.m = m;
        }
        public void printRange()
        {
            Console.WriteLine("Ряд чисел: ");

            for (int i = 0; i < n; i++)
            {
                if (Math.Pow(i, 2) > m)
                    Console.Write(i + ",");
            }

            Console.WriteLine();
        }
    }
}
