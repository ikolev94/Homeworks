using System;
using System.Linq;

class NumberCalculations
{
    private static int minimum(int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        return min;
    }

    private static int maximum(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;

    }

    private static double average(int[] array)
    {
        if (array.Length == 0) return 0.0;
        return ((double)sum(array)) / array.Length;
    }

    private static int sum(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    private static int product(int[] array)
    {
        int result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }

    private static double minimum(double[] array)
    {
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        return min;
    }

    private static double maximum(double[] array)
    {
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;

    }

    private static double average(double[] array)
    {
        if (array.Length == 0) return 0.0;
        return ((double)sum(array)) / array.Length;
    }

    private static double sum(double[] array)
    {
        double result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    private static double product(double[] array)
    {
        double result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter integers: ");
        int[] intNumbers = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).ToArray();
        Console.WriteLine("Integer array minimum: {0}", minimum(intNumbers));
        Console.WriteLine("Integer array maximum: {0}", maximum(intNumbers));
        Console.WriteLine("Integer array average: {0}", average(intNumbers));
        Console.WriteLine("Integer array sum: {0}", sum(intNumbers));
        Console.WriteLine("Integer array product: {0}", product(intNumbers));

        Console.Write("Enter doubles: ");
        double[] doubleNumbers = Console.ReadLine().Trim().Split().Select(p => double.Parse(p)).ToArray();
        Console.WriteLine("Double array minimum: {0}", minimum(doubleNumbers));
        Console.WriteLine("Double array maximum: {0}", maximum(doubleNumbers));
        Console.WriteLine("Double array average: {0}", average(doubleNumbers));
        Console.WriteLine("Double array sum: {0}", sum(doubleNumbers));
        Console.WriteLine("Double array product: {0}", product(doubleNumbers));
    }
}