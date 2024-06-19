using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 8, 4 };

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
    }
}
