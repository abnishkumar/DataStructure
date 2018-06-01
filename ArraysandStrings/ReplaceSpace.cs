using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandStrings
{
    /// <summary>
    /// WAP to replace all space in a string with %20.
    /// </summary>
    public class ReplaceSpace
    {
        public void ReplaceSpaceWithPercent20(string str)
        {
            Console.WriteLine("===========Replace Spacewith %20============");
            string[] arr= str.Select(x=>x.ToString()).ToArray();
            int length = arr.Count();
            for (int i = 0; i < length; i++)
            {
                string ele = arr.ElementAt(i);
                if (string.IsNullOrWhiteSpace(ele))
                {
                    arr[i] = "%20";
                }
            }

            
            Console.WriteLine($"{str} replace with %20 is {string.Concat(arr)}");
        }

    }
}
