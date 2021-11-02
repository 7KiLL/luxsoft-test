using System;
using System.Collections.Generic;
using System.Linq;

namespace Luxsoft.Library
{
    public class ArraySequenceSum
    {
        private readonly int _sum;
        private readonly int[] _sequence;

        public ArraySequenceSum(int min, int max, int sum)
        {
            if (max <= min)
            {
                throw new ArgumentException("[max] should be larger then [min]");
            }

            if (min <= 0 || max <= 0)
            {
                throw new ArgumentException("Numbers should be larger than 0");
            }

            _sum = sum;
            _sequence = CreateSequence(min, max);
        }

        public int[] GetResultAsArray()
        {
            return _sequence
                .Where(x => IntToArray(x)
                    .Sum()
                    .Equals(_sum)
                )
                .ToArray();
        }

        private int[] CreateSequence(int min, int max)
        {
            return Enumerable.Range(min, count: max - min + 1).ToArray();
        }

        /// <summary>
        /// Method can be found at <a href="https://stackoverflow.com/a/4808815">StackOverflow</a>
        /// </summary>
        /// <param name="number">An integer to be parsed</param>
        /// <returns>Array of integer digits</returns>
        private IEnumerable<int> IntToArray(int number)
        {
            List<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            digits.Reverse();
            return digits.ToArray();
        }
    }
}