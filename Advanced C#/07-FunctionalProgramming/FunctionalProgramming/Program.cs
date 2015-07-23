using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class Program
    {
        static void Main()
        {

            List<Student> students = new List<Student>();
            {
                students.Add(new Student("Ivan", "Ivaov", 12, "12314231", "02892532393", "qko@abv.bg", new List<int>() { 6, 4, 5 }, 2));
                students.Add(new Student("Trifon", "Kostov", 19, "12314644", "09523253235", "231@yahoo.com", new List<int>() { 2, 6, 2 }, 4));
                students.Add(new Student("Panayot", "Kadiev", 37, "12311419", "09891333410", "dobre@abv.bg", new List<int>() { 6, 4, 2 }, 2));
                students.Add(new Student("kiro", "yovov", 16, "12311465", "0989136347", "ab35b@bg", new List<int>() { 4, 4, 6 }, 1, "Umni"));
                students.Add(new Student("Angel", "Borimirov", 55, "12335633", "09892794684", "afdhdfb@bg", new List<int>() { 6, 4, 6 }, 1, "Silni"));
            }

            Console.WriteLine("1.Students by Group:");
            var groupTwo =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                group student by student.GroupNumber;

            foreach (var studentsInGroupTwo in groupTwo)
            {
                Console.WriteLine("Group:" + studentsInGroupTwo.Key);
                foreach (var human in studentsInGroupTwo)
                {
                    Console.WriteLine("--{0} {1} Age:{2} Faculty number:{3} Phone:{4} Email:{5}"
                        , human.FirstName, human.LastName, human.Age, human.FacultyNumber, human.Phone, human.Email);
                    Console.Write("Marks: ");
                    foreach (var results in human.Marks)
                    {
                        Console.Write(results + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("2.Students by First and Last Name:");
            var firstbeforLastNameStudents =
                //students.Where(student => student.FirstName.CompareTo(student.LastName) < 0);
                from student1 in students
                where student1.FirstName.CompareTo(student1.LastName) < 0
                select student1;
            foreach (var human in firstbeforLastNameStudents)
            {
                Console.WriteLine("--{0} {1} Age:{2} Faculty number:{3} Phone:{4} Email:{5}"
                    , human.FirstName, human.LastName, human.Age, human.FacultyNumber, human.Phone, human.Email);
                Console.Write("Marks: ");
                foreach (var results in human.Marks)
                {
                    Console.Write(results + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("3.Students by Age:");
            var studentsByAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new { student.FirstName, student.LastName, student.Age };

            foreach (var student in studentsByAge)
            {
                Console.WriteLine("--{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine("4.Sort Students:");
            var sortStudent = students.OrderBy(student => student.FirstName).ThenByDescending(student => student.LastName);
            var sortStudentQuery =
                from student in students
                orderby student.FirstName, student.LastName descending
                select student;
            foreach (var student in sortStudentQuery)
            {
                Console.WriteLine("--{0} {1} Age:{2} Faculty number:{3} Phone:{4} Email:{5}"
                    , student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email);
                Console.Write("Marks: ");
                foreach (var results in student.Marks)
                {
                    Console.Write(results + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("extension methods");
            foreach (var student in sortStudent)
            {
                Console.WriteLine("--{0} {1} Age:{2} Faculty number:{3} Phone:{4} Email:{5}"
                    , student.FirstName, student.LastName, student.Age, student.FacultyNumber, student.Phone, student.Email);
                Console.Write("Marks: ");
                foreach (var results in student.Marks)
                {
                    Console.Write(results + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("5 Filter students by email");
            var emailQuery =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;
            foreach (var student in emailQuery)
            {
                Console.WriteLine("--{0} {1} Email:{2}"
                   , student.FirstName, student.LastName, student.Email);
            }

            Console.WriteLine("6 Filter students by phone");
            var PhoneQuery =
                from student in students
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student;
            foreach (var student in emailQuery)
            {
                Console.WriteLine("--{0} {1} Phone:{2}"
                   , student.FirstName, student.LastName, student.Phone);
            }

            Console.WriteLine("7 Excellent students");
            var ExecllentSutudens =
                from student in students
                where student.Marks.Contains(6)
                select new { student.FirstName, student.LastName, student.Marks };
            foreach (var student in ExecllentSutudens)
            {
                Console.WriteLine("--{0} {1} Marks:{2}"
                   , student.FirstName, student.LastName, string.Join(" ,", student.Marks));
            }

            Console.WriteLine("8 Week students");
            List<int> ffs = new List<int>();
            {
                ffs.Add(2);
                ffs.Add(2);
            }
            var WeekStudents =
                from student in students
                where student.Marks.FindAll(grade => grade == 2).Count == 2
                select new { student.FirstName, student.LastName, student.Marks };
            foreach (var student in WeekStudents)
            {
                Console.WriteLine("--{0} {1} Marks:{2}"
                   , student.FirstName, student.LastName, string.Join(" ", student.Marks));
            }

            Console.WriteLine("9 students enrolled in 2014");
            var yearQuery =
               from student in students
               where student.FacultyNumber[4] == '1' && student.FacultyNumber[5] == '4'
               select student;
            foreach (var student in yearQuery)
            {
                Console.WriteLine("--{0} {1} {2}",
                    student.FirstName, student.LastName, student.FacultyNumber);
            }

            Console.WriteLine("10 students by groups");
            var groupNames =
                from student in students
                group student by student.GroupName;
            foreach (var group in groupNames)
            {
                Console.WriteLine(group.Key);
                foreach (var stud in group)
                {
                    Console.WriteLine("-->{0} {1}", stud.FirstName, stud.LastName);
                }
            }



        }
    }
}
