using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseString("Hello");
            GulamString("Test");
        }
        //internal static void ReverseString(string str)
        //{

        //    char[] charArray = str.ToCharArray();
        //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        //    {
        //        charArray[i] = str[j];
        //        charArray[j] = str[i];
        //    }
        //    string reversedstring = new string(charArray);
        //    Console.WriteLine(reversedstring);
        //}

        internal static void GulamString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int g = 0, u = str.Length - 1; g < u; g++, u--)
            {
                charArray[g] = str[u];
                charArray[u] = str[g];
            }
            string reveredstring = new string(charArray);
            Console.WriteLine(reveredstring);
        }
    }
}
