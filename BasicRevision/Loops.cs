using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRevision
{
    public static class Loops
    {
        public static void MainLoop()
        {

            List<string> names = new List<string> { "Ahmed", "Mohamed", "Ali", "Youns", "Amr" };

            int[] Ages = new int[] { 15, 18, 19, 13, 10, 20 };

            // loop
            // for


            //for (int i = 0; i < Ages.Length; i = i + 2)
            //{
            //    Console.WriteLine($@"
            //Index: {i}
            //number of array: {Ages[i]}");
            //}

            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine($@"
            //Index: {i}
            //Name: {names[i]}");
            //}
            // foreach
            foreach (string name in names)
            {
                Console.WriteLine($@"the name is {name}");
                //if (name== "Ali")
                //{
                //    break;
                //}
            }
            // do
            int index = 0;
            do
            {
                if (names[index].StartsWith("A"))
                {
                    Console.WriteLine($"this name is start with A: {names[index]}");
                }
                else
                {
                    Console.WriteLine($"this name is not start with A: {names[index]}");
                }
                index++;
            } while (index < names.Count);



            // while

            int i = 0;
            while (i < Ages.Length)
            {
                if (Ages[i] >= 18)
                {
                    Console.WriteLine($@"
this person is adult
his age is{Ages[i]}
");
                }
                else
                {
                    Console.WriteLine($@"
this person is not adult
his age is{Ages[i]}
");
                }
                i++;
            }
        }
    }
}

