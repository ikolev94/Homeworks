using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
internal class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (count > arr.Length)
        {
            throw new InvalidOperationException("Count cannot be bigger then the arrays length");
        }

        if (startIndex > arr.Length)
        {
            throw new InvalidOperationException("Start index cannot be bigger then the arrays length");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }
    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new AggregateException("Count cannot be biger than words lenght");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }
    public static bool CheckPrime(int number)
    {
        var isPrime = false;
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = true;
                break;
            }
        }

        return isPrime;
    }

    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        try
        {
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (CheckPrime(23))
        {
            Console.WriteLine("23 is prime");
        }
        else
        {
            Console.WriteLine("23 is not prime");
        }

        List<Exam> peterExams = new List<Exam>
        {
            new SimpleMathExam(2), 
            new CSharpExam(55), 
            new CSharpExam(100), 
            new SimpleMathExam(1), 
            new CSharpExam(0)
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}