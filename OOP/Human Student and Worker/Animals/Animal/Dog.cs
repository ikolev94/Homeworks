using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animal
{
    class Dog :Animals
    {
        public Dog(string name, string gender, int age) : base(name, gender, age)
        {
        }

        public override string SoundMake()
        {
            return "bau";
        }
    }
}
