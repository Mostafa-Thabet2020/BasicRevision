using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRevision
{
    internal static class LinqOperatorsConsole
    {
        public static void Main()
        {
            Console.WriteLine($"Number of Adult Student: {LINQOperators.AdultStudentCount()}");
            Console.WriteLine($"Is there adult student: {LINQOperators.IsThereAdult()}");

            List<Student> students = LINQOperators.OrderdStudent();

            //foreach (var item in students)//normal loop
            //{
            //    Console.WriteLine($"Age: {item.Age}\n" +
            //        $"Name: {item.Name}");
            //}

            students.ForEach(x => {// loop as lampda exepration
                Console.WriteLine($"Age: {x.Age}\n" +
                    $"Name: {x.Name}");
            });

            Console.WriteLine($"Age avarage: {LINQOperators.StudentAgeAvarage()}");

            Console.WriteLine($"Total Ages: {LINQOperators.TotalAge()}");

            Console.WriteLine($"Max age: {LINQOperators.BiggestAge()}");

            Console.WriteLine($"Min age: {LINQOperators.SmallestAge()}");

            LINQOperators.TakeThree().ForEach(x =>// loop by lampda experation
            {
                Console.WriteLine(x.Name);
            });

            for (int i = 0; i < LINQOperators.TakeThree().Count; i++)// loop by for
            {
                Console.WriteLine(LINQOperators.TakeThree()[i].Name);
            }

            LINQOperators.SkipOne().ForEach(x =>
            {
                Console.WriteLine(x.Id + "." + x.Name);
            });
        }
    }
}
