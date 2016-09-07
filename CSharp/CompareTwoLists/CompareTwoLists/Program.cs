using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> la = new List<int>() { 1, 0, 4, 200, -40 };
            List<int> lb = new List<int>() { -40, 200, 4, 1, 0 };
            List<int> lc = new List<int>() { 3, 5, 4, 9, 11 };
            List<int> ld = new List<int>() { 6, 6, 100 };
            List<int> le = new List<int>() { 6, 100, 100 };
            Console.WriteLine(UnorderedEqual(la, lb)); // true
            Console.WriteLine(UnorderedEqual(la, lc)); // false
            Console.WriteLine(UnorderedEqual(lc, ld)); // false
            Console.WriteLine(UnorderedEqual(ld, le)); // false

            int[] a1 = new int[] { 1, 2, 5 };
            int[] a2 = new int[] { 2, 5, 1 };
            int[] a3 = new int[] { 1, 1, 3 };
            int[] a4 = new int[] { 3, 3, 1 };
            Console.WriteLine(UnorderedEqual(a1, a2)); // true
            Console.WriteLine(UnorderedEqual(a1, a3)); // false
            Console.WriteLine(UnorderedEqual(a3, a4)); // false

            Console.ReadLine();
        }

        static bool UnorderedEqual<T>(ICollection<T> a, ICollection<T> b)
        {
            // 1
            // Require that the counts are equal
            if (a.Count != b.Count)
            {
                return false;
            }
            // 2
            // Initialize new Dictionary of the type
            Dictionary<T, int> d = new Dictionary<T, int>();
            // 3
            // Add each key's frequency from collection A to the Dictionary
            foreach (T item in a)
            {
                int c;
                if (d.TryGetValue(item, out c))
                {
                    d[item] = c + 1;
                }
                else
                {
                    d.Add(item, 1);
                }
            }
            // 4
            // Add each key's frequency from collection B to the Dictionary
            // Return early if we detect a mismatch
            foreach (T item in b)
            {
                int c;
                if (d.TryGetValue(item, out c))
                {
                    if (c == 0)
                    {
                        return false;
                    }
                    else
                    {
                        d[item] = c - 1;
                    }
                }
                else
                {
                    // Not in dictionary
                    return false;
                }
            }
            // 5
            // Verify that all frequencies are zero
            foreach (int v in d.Values)
            {
                if (v != 0)
                {
                    return false;
                }
            }
            // 6
            // We know the collections are equal
            return true;
        }
    }
}
