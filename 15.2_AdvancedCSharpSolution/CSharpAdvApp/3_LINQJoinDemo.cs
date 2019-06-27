using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpAdvApp
{
    class _3_LINQJoinDemo
    {
       public static void Main()
        {
            IList<string> strList1 = new List<string>()
        {
            "One",
            "Two",
            "Three","Four"
        };

            IList<string> strList2 = new List<string>() {
               "One",
                "Two",
                "Five",
                "Six" };


            var innerJoin = strList1.Join(strList2,
                               str1 => str1,
                               str2 => str2,
                               (str1, str2) => str1);

        
            foreach (var str in innerJoin)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }


    };
    }

