using System;


namespace CSharpAdvApp
{


    public sealed class MathEngine
    {
        public int Add(int num1, int num2) { return num1 + num2; }
        public int Sub(int num1, int num2) { return num1 - num2; }
        public int Div(int num1, int num2) { return num1 / num2; }
    }


    public  static class Helper
    {
        //Custom Extenstion Method

        public static bool  IsGreaterThan(this int i,int value)
        {
            return i > value;
        }
        public static int Mult(this MathEngine m,int num1, int num2)
        {
            return num1 * num2;

        }
    }
    class Program_01_ExtensionM
    {
        
        static void Main(string[] args)
        {
            int i = 10;
            bool result=i.IsGreaterThan(100);

            MathEngine engine = new MathEngine();
            engine.Add(34, 34);
            engine.Sub(34, 34);
            engine.Div(34, 34);
            int numResult = engine.Mult(34, 34);
            Console.WriteLine("Multiplication result={0}", numResult);
            Console.ReadLine();
        }
    }
}
