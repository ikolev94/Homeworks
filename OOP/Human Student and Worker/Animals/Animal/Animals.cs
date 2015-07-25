using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Animal
{
    abstract class Animals :ISound
    {
        private string name;
        private string gender;
        private int age;

        public Animals(string name, string gender,int age )
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract string SoundMake();

        public override string ToString()
        {
            return string.Format("Name: {0} Gender: {1} Age: {2}", this.Name, this.Gender, this.Age);
        }
    }
}
