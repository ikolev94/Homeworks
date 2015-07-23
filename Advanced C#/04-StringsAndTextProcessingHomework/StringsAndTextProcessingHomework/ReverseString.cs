using System;

class ReverseString
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string reverse = String.Empty;
        for (int i = input.Length-1; i >= 0; i--)
        {
            char temp = input[i];
            reverse += temp;
        }
        Console.WriteLine(reverse);
    }
}

