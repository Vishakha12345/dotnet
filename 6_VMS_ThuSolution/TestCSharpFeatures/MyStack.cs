using System;
namespace TestCSharpFeatures
{
    class MyStack :ICloneable
    {
        int size;
        int[] sArr;

        public MyStack(int s)
        {
            size = s;
            sArr = new int[size];
            for(int i = 0; i < size - 1; i++)
            {
                sArr[i] = i;
            }
        }



        public object Clone()
        {
            //Deep copy
            MyStack s = new MyStack(this.size);
            this.sArr.CopyTo(s.sArr, 0);
            return s;
        }


        public static void Main()
        {

            MyStack st1 = new MyStack(5);
            MyStack st2 = st1;  //shallow copy
            MyStack st3 = (MyStack)st1.Clone();


        }

    }
}
