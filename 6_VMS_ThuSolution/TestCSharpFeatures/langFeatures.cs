using System;
namespace TestCSharpFeatures
{
    public class College
    {
        private  const int strength=200;

        private readonly string name;

        public College(string name)
        {
            this.name = name;
            
        }
    }


    enum Weekday { Mon, Tue, Wed, thu, Fri, Sat};
    enum ConsoleColor { Red, Green, Yello, Blue, Pink};

    public struct Point
    {
        public int x;
        public int y;

    }
    public class Test
    {
        public static void Main()
        {
            Weekday day = Weekday.Mon;
            Console.WriteLine("Today is {0}", day);
            Point pixel = new Point();
            pixel.x = 45;
            pixel.y = 57;

            int[] marks;
            marks = new int[3];
            marks[0] = 56;
            marks[1] = 76;
            marks[2] = 78;


            foreach (int i in marks) {
                Console.WriteLine(i);
            }

            string[] students = { "Raj", "Seema", "Jagan" };
            foreach (string   name in students) {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }
    }
}
