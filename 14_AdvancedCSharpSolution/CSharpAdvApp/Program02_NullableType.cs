using System;


namespace CSharpAdvApp
{
    class Program02_NullableType
    {
        public static void Main()
        {
                    
            int? j = null;
            double? d = null;
         
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            // use '??' operator to assign 
            //a nullable type to  non-nullable type

            int k = i ?? 0;
            Console.WriteLine(k);

        }
    }
}
