namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public abstract class Course
    {
        protected Course(string name, string teacherName = null, IList<string> students = null, string place = null)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Place = place;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public string Place { get; set; }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}