using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRevision
{
    public static class Operators
    {
        public static void MainOperators()
        {
            //Operators
            //Arithmetic Operators
            //Mathmatic opertors="+,-,*,/,++,--"
            int p = 5;
            int x = 5;
            //string ArithmeticOperators = $@"
            //1+1={1 + 1}
            //3-1={3 - 1}
            //3*3={3 * 3}
            //50/10={50 / 10}
            //{p++}
            //{p++}
            //{x--}
            //{x--}
            //";
            //Console.WriteLine(ArithmeticOperators);

            //Relational Operators = "==,!=,>,<,<=,>="

            //Logical Operators = "&&,||,!"

            //Assignment Operators = "=,+=,-=,*=,/="
            p += x;

            Console.WriteLine(p);//p=p+x
            p -= x;
            Console.WriteLine(p);//p=p-x
        }
    }
}
