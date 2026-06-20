using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLinqPractice.LINQCodeFiles
{
    public static class LinqToObjects
    {
        public static void Run(int[] numbers) {
            IEnumerable<int> evenNumbers = from number in numbers
                                           where number % 2 == 0
                                           select number;
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
