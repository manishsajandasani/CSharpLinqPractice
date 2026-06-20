using System;
using CSharpLinqPractice.LINQCodeFiles;

namespace CSharpLinqPractice;

internal class Program
{
    static void Main(string[] args)
    {
        //LinqToObjects.FindEvenNumbers(new int[] { 59, 64, 72, 85, 97, 113, 126, 144, 158, 161 });
        //LinqToInMemoryDatabase.FindMaleEmployees();
        LinqToEntities.FindFemaleEmployees();

        Console.ReadKey();
    }
}
