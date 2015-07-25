using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_and_Worker
{
    class Student:Human
    {
        private string facultyNumber;
        public Student(string first, string last,string falcultyNumber) : base(first, last)
        {
            this.FacultyNumber = falcultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length>5&&value.Length<10)
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new FormatException("Faculty number must be in [5..10] range");
                }
            }
        }

        public override string ToString()
        {
            return base.ToString()+" faculty number"+this.facultyNumber;
        }
    }
}
