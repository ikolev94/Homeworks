using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animal
{
    class Kitten :Cat
    {
        public Kitten(string name, int age) : base(name, "Fimale", age)
        {
        }

        public override string SoundMake()
        {
            return "hhhhhh";
        }
    }
}
