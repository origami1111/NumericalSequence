using System;
using System.Text;

namespace NumericalSequence
{
    class NumericalSequence
    {
        private StringBuilder sequence;
        private uint length;
        private uint minPow;

        public NumericalSequence() { }
        public NumericalSequence(uint length, uint minPow)
        {
            this.length = length;
            this.minPow = minPow;
        }
        public override string ToString()
        {
            return (sequence.ToString());
        }
        public void CreateSequence()
        {
            sequence = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                if (Math.Pow(i, 2) > minPow)
                {
                    sequence.Append(i + ",");
                }
            }

            if(sequence.Length == 0)
            {
                sequence.Append($"Не существует числ ряда длиной {length} меньше заданного квадрата {minPow}");
            }
        }
    }
}
