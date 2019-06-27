using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;
namespace TestDelegate
{
    delegate void ArithmaticOpeation(int op1, int op2);


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number");
            int num2 = int.Parse(Console.ReadLine());

            MathLib.Calculator calc = new Calculator();
            //calc.Add(num1, num2);
            ArithmaticOpeation opn1 = new ArithmaticOpeation(calc.Add);

            ArithmaticOpeation opn2 = new ArithmaticOpeation(calc.Sub);
            ArithmaticOpeation opn = opn1;
            opn += opn2;

            opn(num1, num2);  //it is only one call invocation



            int result = calc.Result;
            Console.WriteLine("Result =" + result);
            Console.ReadLine();


        }
    }
}
