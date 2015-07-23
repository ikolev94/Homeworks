using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static void Main()
    {
        
        int sum = int.Parse(Console.ReadLine());
        
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool chek = true;
        List<int> final = numbers.ToList();
        final = final.Distinct().ToList();

        var subsets = from m in Enumerable.Range(0, 1 << final.Count)
                      select
                          from i in Enumerable.Range(0, final.Count)
                          where (m & (1 << i)) != 0
                          select final[i];
        
        
        foreach (var item in subsets)
        {
            int sumTemp = 0;
            foreach (var number in item)
            {
                sumTemp += Convert.ToInt32(number);
            }
            if (sumTemp == sum && item.Count() > 0)
            {
                Console.WriteLine(string.Join(" + ", item) + " = {0}", sum);
                chek = false;
            }
        }
        if (chek)
            Console.WriteLine("No matching subsets.");
    }
}