using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRevision
{
    internal static class LINQOperators//StudentService
    {
        //Linq or Lampda experation = Query + excution;
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){Id=1,Age=20,Name="Samy"},
                new Student(){Id=2,Age=15,Name="Ahmed"},
                new Student(){Id=3,Age=23,Name="Morsy"},
                new Student(){Id=4,Age=13,Name="Mona"},
                new Student(){Id=5,Age=17,Name="Ali"},
            };
        }
        public static int AdultStudentCount()
        {
            List<Student> students = GetStudents();
            return students.Where(x => x.Age >= 18)//Query
                .Count();//Excution
        }
        public static bool IsThereAdult()
        {
            return GetStudents().Any(x => x.Age >= 18);
        }
        public static List<Student> OrderdStudent()
        {
            return GetStudents().OrderBy(x => x.Age)//Query
                                .ToList();//Excution
        }

        public static double StudentAgeAvarage()
        {
           return GetStudents().Average(x => x.Age);
        }

        public static int TotalAge()
        {
            return GetStudents().Sum(x => x.Age);
        }

        public static int BiggestAge()
        {
            return GetStudents().Max(x => x.Age);
        }

        public static int SmallestAge()
        {
            return GetStudents().Min(x => x.Age);
        }

        public static List<Student> TakeThree()
        {
            return GetStudents().OrderByDescending(x=>x.Id).Take(3)//Query
                .ToList();//Exction
        }
        public static List<Student> SkipOne()
        {
            return GetStudents().Skip(1)// Query
                .ToList();
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
