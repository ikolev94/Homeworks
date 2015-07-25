using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> genericList = new GenericList<string>();
            genericList.Add("a");
            genericList.Add("b");
            genericList.Add("c");
            Console.WriteLine(genericList);
            Console.WriteLine("Max = {0}, Min = {1}",genericList.Max(),genericList.Min());
            Console.WriteLine("Remove b");
            genericList.Remove("b");
            Console.WriteLine(genericList);
            Console.WriteLine("genericList[0] = "+genericList.Access(0));
            Console.WriteLine("index of c = "+genericList.FindIndex("c"));
            genericList.Clear();
            genericList.Add("rom");
            genericList.Add("mon");
            genericList.Add("dom");
            Console.WriteLine(genericList);
            Console.WriteLine("Insert zom (index = 1)");
            genericList.Insert("zom",1);
            Console.WriteLine(genericList);
            Console.WriteLine(genericList.Contains("mon"));
            Console.WriteLine(genericList.Contains("aaa"));
          
            Type type = typeof(GenericList<>);
            object[] allAttributes = type.GetCustomAttributes(typeof(VersionAttribute), false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("This class's version is {0}.", attr.Version);
            }

        }
    }
}
