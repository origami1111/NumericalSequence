using System;

namespace NumericalSequence
{
    class View
    {
        private NumericalSequence numericalSequence;
        private void PrintTask()
        {
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine("Вывести через запятую ряд длиной n, состоящий из натуральных чисел, квадрат которых не меньше заданного m." +
                              "\nВходные параметры: длина и значение минимального квадрата" +
                              "\nВыход: строка с рядом чисел");
            Console.WriteLine("==========================================================================================================");
        }
        private void PrintHelp()
        {
            Console.WriteLine("==========================================================================================================");
            Console.WriteLine("Возможные аргументы:" +
                              "\n-help - информация о возможных аргументах" +
                              "\n-task - информация о задаче");
            Console.WriteLine("==========================================================================================================");
        }

        public void CheckArguments(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
            }
            else
            {
                foreach (var arg in args)
                {
                    switch (arg)
                    {
                        case "-help":
                            PrintHelp();
                            break;
                        case "-task":
                            PrintTask();
                            break;
                        default:
                            Console.WriteLine("Указанного аргумента не существует. Чтобы посмотреть список аргументов, укажите '-help'");
                            break;
                    }
                }
            }
        }

        public void PrintSequence()
        {
            numericalSequence = new NumericalSequence(GetLengthSequence(), GetMinPow());
            numericalSequence.CreateSequence();
            Console.WriteLine(numericalSequence);
        }

        private uint GetLengthSequence()
        {
            uint length;

            while (true)
            {
                Console.Write("Введите длину ряда: ");

                if((!uint.TryParse(Console.ReadLine(), out length)) || length == 0)
                {
                    Console.WriteLine($"Введите число в диапазоне [1;{uint.MaxValue}]");
                }
                else
                {
                    break;
                }
            }

            return length;
        }
        private uint GetMinPow()
        {
            uint minPow;

            while (true)
            {
                Console.Write("Введите значение минимального квадрата: ");

                if ((!uint.TryParse(Console.ReadLine(), out minPow)) || minPow == 0)
                {
                    Console.WriteLine($"Введите число в диапазоне [1;{uint.MaxValue}]");
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
