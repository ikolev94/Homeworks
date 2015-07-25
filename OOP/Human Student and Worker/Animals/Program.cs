using System;
using System.Collections.Generic;
using Animals.Animal;

namespace Animals
{
    internal class Program
    {
        private static void Main()
        {
            List<Animal.Animals> animals = new List<Animal.Animals>()
            {
                new Dog("bobi","male",4),
                new Cat("Moni","female",7),
                new Kitten("hihi",5),
                new Frog("goog","male",3),
                new Tomcat("rex",8),
                new Kitten("nana",9),
                new Dog("koko","Male",3),
                new Frog("fofo","female",7),
                new Cat("lala","female",5),
                new Tomcat("dodo",9)
            };
            var animalsBySort = new Dictionary<string, List<double>>();

            foreach (var beast in animals)
            {
                if (!animalsBySort.ContainsKey(beast.GetType().Name))
                {
                    animalsBySort.Add(beast.GetType().Name, new List<double>());
                    animalsBySort[beast.GetType().Name].Add(0);
                    animalsBySort[beast.GetType().Name].Add(0);
                }
                animalsBySort[beast.GetType().Name][0] += beast.Age;
                animalsBySort[beast.GetType().Name][1] ++;
            }

            foreach (var pair in animalsBySort)
            {
                double averageAge = pair.Value[0]/pair.Value[1];
                Console.WriteLine("{0}s average age is {1:##.###}",pair.Key,averageAge);
            }

        }
    }
}
