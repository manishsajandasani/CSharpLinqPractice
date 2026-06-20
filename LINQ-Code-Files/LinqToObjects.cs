namespace CSharpLinqPractice.LINQCodeFiles;

public static class LinqToObjects
{
    public static void FindEvenNumbers(int[] numbers)
    {
        IEnumerable<int> evenNumbers = from number in numbers
                                       where number % 2 == 0
                                       select number;
        foreach(var number in evenNumbers)
        {
            Console.WriteLine($"{number} is an Even Number");
        }
    }
}

