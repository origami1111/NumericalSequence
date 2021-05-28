using System;

namespace NumericalSequence
{
    class View
    {
        public uint GetLengthSequence()
        {
            uint length;

            while (true)
            {
                Console.Write("Введите длину ряда: ");

                if((!uint.TryParse(Console.ReadLine(), out length)) || length == 0)
                {
                    Console.WriteLine("Введите целое положительное число больше 0");
                }
                else if(length > uint.MaxValue)
                {
                    Console.WriteLine($"Слишком большое число! Максимальное допустимое число {uint.MaxValue}");
                }
                else
                {
                    break;
                }
            }

            return length;
        }
        public uint GetMinPow()
        {
            uint minPow;

            while (true)
            {
                Console.Write("Введите значение минимального квадрата: ");

                if ((!uint.TryParse(Console.ReadLine(), out minPow)) || minPow == 0)
                {
                    Console.WriteLine("Введите целое положительное число больше 0");
                }
                else if (minPow > uint.MaxValue)
                {
                    Console.WriteLine($"Слишком большое число! Максимальное допустимое число {uint.MaxValue}");
                }
                else
                {
                    break;
                }
            }

            return minPow;
        }
    }
}
