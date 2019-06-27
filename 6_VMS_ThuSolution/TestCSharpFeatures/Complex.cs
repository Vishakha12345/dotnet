using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFeatures
{
   public  class Complex
    {

        int real;
        int imag;
        public Complex(int r, int i)
        {
            real = r;
            imag = i;

        }
        public static Complex operator+ (Complex c1, Complex c2)
        {
            Complex temp = new Complex(0,0);
            temp.real = c1.real+ c2.real;
            temp.imag = c1.imag + c2.imag;
             return temp;
        }


        public static void Main()
        {
            Complex o1 = new Complex(2, 3);
            Complex o2 = new Complex(5, 4);
            Complex o3 = o1 + o2;
            Console.WriteLine(o3.real + " "+o3.imag);
        }


    }
}
