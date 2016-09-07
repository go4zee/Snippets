using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurencesInArray
{
    class Program
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int retVal = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var number in A)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                    dictionary.Add(number, 1);
            }
            foreach (var val in dictionary)
            {
                if ((val.Value) % 2 != 0)
                {
                    retVal = val.Key;
                }
            }

            return (retVal);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = new int[] { 1, 4, 6, 5, 7, 4, 5, 6, 7 };
            int answer = p.solution(A);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
