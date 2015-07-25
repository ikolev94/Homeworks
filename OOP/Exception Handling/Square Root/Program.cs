using System;

class Program
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number<0)
            {
                throw new FormatException("Negative numbrer");
            }
            double sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid number");

        }
        finally
        {
            Console.WriteLine("Good bye");
        }

    }
}

