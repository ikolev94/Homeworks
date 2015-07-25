using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Ogi", 100);

            student.OnPropertyChanged += PropertyHandler;

            student.Name = "Ivan";
            student.Age = 22;

            student.OnPropertyChanged -= PropertyHandler;

            student.OnPropertyChanged += (sender, eventArgs) =>
                {
                    Console.WriteLine(
                        "Property changed: {0} (from {1} to {2})",
                        eventArgs.PropertyName,
                        eventArgs.OldValue,
                        eventArgs.NewValue);
                };
            student.Name = "Maria";
            student.Age = 19;

        }

        private static void PropertyHandler(object sender, PropertyChangedEventArgs eventArgs)
        {
            Console.WriteLine(
                "Property changed: {0} (from {1} to {2})",
                eventArgs.PropertyName,
                eventArgs.OldValue,
                eventArgs.NewValue);
        }
    }
}

