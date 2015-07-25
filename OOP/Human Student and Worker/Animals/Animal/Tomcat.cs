using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animal
{
    class Tomcat :Cat
    {
        public Tomcat(string name, int age) : base(name, "Male", age)
        {
        }

        public override string SoundMake()
        {
            return "Rrrrr";
        }
    }
}
