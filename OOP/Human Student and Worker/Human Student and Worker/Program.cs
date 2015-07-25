using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_and_Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("asdf","sdf","2223454");
            Worker b = new Worker("GOgo","Kokov",11,2);
            
            List<Student> students = new List<Student>()
            {
                new Student("iva","kodeva","111213"),
                new Student("ogi","ogev","111214"),
                new Student("Qna","koseva","110213"),
                new Student("pop","vogev","99999999"),
                new Student("gogo","angelov","1911213"),
                new Student("lazar","gepov","112111"),
                new Student("ivon","kva","112143"),
                new Student("opos","videv","111114"),
                new Student("ia","kopanarov","171213"),
                new Student("gigi","kadmov","1112914"),
            };
            List<Worker> workers = new List<Worker>()
            {
                new Worker("boncho","bonev",8000,8),
                new Worker("yavor","ibrqmov",11,9),
                new Worker("pravdolub","kolev",5,1),
                new Worker("moma","momova",444,4),
                new Worker("joro","fading",800,8),
                new Worker("boncho","bobev",1000,8),
                new Worker("rednik","osogov",101,9),
                new Worker("stanyo","koskov",45,10),
                new Worker("manamana","petrova",44422,9),
                new Worker("opo","ngov",200,18),
            };
            var sortStudents = students.OrderBy(s => s.FacultyNumber);
            Console.WriteLine("Students");
            foreach (var student in sortStudents)
            {
                Console.WriteLine("name :{0} last name :{1} faculty number :{2}",student.FirstName,student.LastName,student.FacultyNumber);
            }
            var sortWorkes = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine("Workes");
            foreach (var worker in sortWorkes)
            {
                Console.WriteLine("first name: {0} Last name: {1} money per h:{2:F}",worker.FirstName,worker.LastName,worker.MoneyPerHour());
            }
        }
    }
}
