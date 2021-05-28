using System;

namespace NumericalSequence
{
    class ConsoleController
    {
        private NumericalSequence numericalSequence;
        private View view;

        public ConsoleController() { }
        public void Start()
        {
            view = new View();
            numericalSequence = new NumericalSequence(view.GetLengthSequence(), view.GetMinPow());
            numericalSequence.CreateSequence();
            Console.WriteLine(numericalSequence);
        }
    }
}
