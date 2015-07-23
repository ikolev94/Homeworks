using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string inputy = String.Empty;
        for( ; ; )
        {
            string input = Console.ReadLine();
            if (input == "search")
            {
                break;
            }
            string[] arr = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            phonebook.Add(arr[0], arr[1]);
        }
        for (;;)
        {
            string search = Console.ReadLine();
            if (!phonebook.ContainsKey(search))
            {
                Console.WriteLine("Conrtact {0} does not exist",search);
            }
            else
            {
                Console.WriteLine("{0} -> {1}",search,phonebook[search]);
            }
        }
    }

}
