using System;

internal class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine(GetReversedNumber(a));
    }

    private static double GetReversedNumber(double a)
    {
        string numberInString = Convert.ToString(a);
        string reversed = String.Empty;
        int size = numberInString.Length;
        for (int i = size; i > 0; i--)
        {
            reversed += numberInString[i-1];
        }
        double result = double.Parse(reversed);
        return result;
    }
}
