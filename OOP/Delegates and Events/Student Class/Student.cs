using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    class Student
    {
        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public delegate void PropertyChangedHandler(object sender, PropertyChangedEventArgs args);

        public event PropertyChangedHandler OnPropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                var eventArgs = new PropertyChangedEventArgs("Name", this.name, value);
                this.name = value;
                var onPropertyChanged = this.OnPropertyChanged;
                if (onPropertyChanged != null)
                {
                    onPropertyChanged(this.Name, eventArgs);
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                var eventArgs = new PropertyChangedEventArgs("Age", this.age, value);
                this.age = value;
                var onPropertyChanged = this.OnPropertyChanged;
                if (onPropertyChanged != null)
                {
                    onPropertyChanged(this.Age, eventArgs);
                }
            }
        }
    }
}
