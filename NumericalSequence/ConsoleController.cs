using System;

namespace NumericalSequence
{
    class ConsoleController
    {
        private NumericalSequence numericalSequence;
        private View view;
        private string[] args;

        public ConsoleController(string[] args) 
        {
            this.args = args;
        }
        public void Start()
        {
            view = new View();
            view.CheckArguments(args);
            numericalSequence = new NumericalSequence(view.GetLengthSequence(), view.GetMinPow());
            numericalSequence.CreateSequence();
            Console.WriteLine(numericalSequence);
        }
    }
}
