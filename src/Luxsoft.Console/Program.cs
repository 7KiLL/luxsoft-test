using System;
using Luxsoft.Library;

namespace Luxsoft.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var min = 124;
            var max = 130;
            var sum = 8;
            var result = new ArraySequenceSum(min, max, sum).GetResultAsArray();
            System.Console.WriteLine($"Result for min:{min}, max:{max}, sum:{sum} is [{String.Join(",", result)}]");
        }
    }
}