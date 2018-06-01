using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    public class OneAwayString
    {
        public void CheckOneAwayString(string str1, string str2)
        {
            Console.WriteLine("===========Check one Away string============");

            if ((str1.Length != str2.Length) || (str1 != str2))
            {
                Console.WriteLine("String in Away");
            }
            else
            {
                Console.WriteLine("String in not away");
            }
        }
    }
}
