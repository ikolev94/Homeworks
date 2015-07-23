namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public LocalCourse(string name, string teacherName = null, IList<string> students = null, string place = null)
            : base(name, teacherName, students, place)
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Place != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Place);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}