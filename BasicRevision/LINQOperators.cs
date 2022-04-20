using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
                new Student(){Id=1,Age=20,FirstName="Samy",LastName="Adel"},
                new Student(){Id=2,Age=15,FirstName="Ahmed",LastName="Khalil"},
                new Student(){Id=3,Age=23,FirstName="Morsy"},
                new Student(){Id=4,Age=13,FirstName="Mona"},
                new Student(){Id=5,Age=17,FirstName="Ali"},
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
            return GetStudents().OrderByDescending(x => x.Id).Take(3)//Query
                .ToList();//Exction
        }
        public static List<Student> SkipOne()
        {
            return GetStudents().Skip(1)// Query
                .ToList();
        }
    }
    public abstract class Humen
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract string GetFullName();
        
    }
    class Student:Humen
    {
        public Student(int age)
        {
            Age = age;
        }
        public Student()
        {
            //FullName = $"{FirstName} {LastName}";
            //if (Gender == "F")
            //{
            //    GenderName = "Female";
            //}
            //else
            //{
            //    GenderName = "Male";
            //}
        }
       
        public string Gender { get; set; } = "F";
        public int Age { get; set; }
        public bool IsAdult
        {
            get
            {
                if (Age >= 18)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string FullName;
        public string GenderName
        {
            get
            {
                if (Gender == "F")
                {
                    return "Female";
                }
                else
                {
                    return "Male";
                }
            }
        }

        public override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
    class SchoolClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ClassSubject> classSubjects { get; set; }
    }
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ClassSubject> classSubjects { get; set; }
    }
    class ClassSubject 
    {
        public int ID { get; set; }
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject subject { get; set; }
        public int SchoolClassId { get; set; }
        [ForeignKey("SchoolClassId")]
        public SchoolClass SchoolClass { get; set; }
    }
}
