using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class Anagrame
    {
        public static void StringAnagram()
        {
            string str1 = "Heart";
            string str2 = "earth";
            char[]name1=str1.ToLower().ToCharArray();//string coverts to characterarray
            char[] name2 = str2.ToLower().ToCharArray();
            Array.Sort(name1);
            Array.Sort(name2);
            string val1 = new string(name1);
            string val2 = new string(name2);
            if(val1==val2)
            {
                Console.WriteLine("Both Strings are Anagram");

            }
            else
            {
                Console.WriteLine("Both strings are Not Anagram");
            }

        }
    }
}
