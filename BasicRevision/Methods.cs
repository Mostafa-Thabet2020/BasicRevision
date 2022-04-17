using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRevision
{
    public class Methods
    {
        // access modifer + Data type(returned data) + function name + arguments(if exist)
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sum(int x, int y,int p)//overload
        {
            return x+y+p;
        }
        public void TestFunction()// void dont return any data
        {
            int x =Convert.ToInt32( Console.ReadLine());
            int p =Convert.ToInt32( Console.ReadLine());
           int total= Sum(x, p);
            int otherTotal = Sum(x, p,10);
        }
    }
    //Loops.MainLoop();
    //Operators.MainOperators();

    //method or function
    // access modifer = public , private, protacted, internal

    class A
    {
        protected int p { get; set; }
        public int x { get; set; }
    }

    class b:A
    {
     public void method()
        {
            A a = new A();
            a.x = 1;
            p = 5;
        }   
    }
    
}
