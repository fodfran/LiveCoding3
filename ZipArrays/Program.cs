using System;
using System.Collections.Generic;

namespace ZipArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 5, 2 };
            List<int> b = new List<int> { 3, 6, 4 };
            List<int> ab = ZipArray(a, b);
            Console.WriteLine(ab);
            foreach (int i in ab)
            {
                Console.WriteLine(i);
            }
        }

        static List<int> ZipArray(List<int> a, List<int> b)
        {
            List<int> ab = new List<int>();
            int count = 0;

            while (count < a.Count)
            {
                ab.Add(a[count]);
                ab.Add(b[count]);
                count++;
            }

            return ab;
            
        }
    }
}
