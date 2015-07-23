using System;

class TextFilter
{
    static void Main()
    {
        string[] wordsToRemove = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        foreach (var word in wordsToRemove)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}