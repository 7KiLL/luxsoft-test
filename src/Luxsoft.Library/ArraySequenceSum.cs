using System;
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
            return _sequence.Where(x =>
            {
                return x.ToString()
                    .Select(c => int.Parse(c.ToString()))
                    .Sum()
                    .Equals(_sum);
            }).ToArray();
        }

        private int[] CreateSequence(int min, int max)
        {
            return Enumerable.Range(min, count: max - min + 1).ToArray();
        }
    }
}