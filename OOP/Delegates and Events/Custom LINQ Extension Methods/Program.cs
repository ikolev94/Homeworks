using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> aa = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = aa.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", result));

            List<Student>test=new List<Student>
            {
                new Student("Ivan",22),
                new Student("Gosho",100),
                new Student("Gergana",33),
                new Student("Tosho",44)
            };
            Console.WriteLine(test.Max(s=>s.Age));
        }
    }
}
