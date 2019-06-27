using System;
using System.Collections;

namespace CSharpAdvApp
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    class Program03_Collections
    {


        public static void Main()
        {
            ArrayList list1 = new ArrayList();
            list1.Add(12);
            list1.Add("Two");
            list1.Add(new Person { FirstName = "Sameera", LastName = "Reddy" });
            list1.Add(3);
            list1.Add(4.5);
            list1[0] = 67;
            IList arryList2 = new ArrayList() {100,200};
            foreach( object o in list1)
            {
                Console.WriteLine(o);
            }




            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (var itm in myStack)
                Console.Write(itm);



            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");




            Hashtable ht = new Hashtable()
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 5, null },
                    { "Fv", new Person{ FirstName="Sachin" , LastName="Nene"} },
                    { 8.5F, 8.5 }
                };


            ht.Contains(2);// returns true
            ht.ContainsKey(2);// returns true
            ht.Contains(5); //returns false
            ht.ContainsValue("One"); // returns true
            ht.Clear(); // removes all elements


            ArrayList marks = new ArrayList();
            marks.Add(300); //Boxing
            marks.Add(53);
            marks.Add(53);
            //450000 times
            marks.Add(53);
            marks.Add(53);

            foreach (object o in marks)
            {
                int mark =(int) o;
            }

            Console.ReadLine();
        }
    }
}
