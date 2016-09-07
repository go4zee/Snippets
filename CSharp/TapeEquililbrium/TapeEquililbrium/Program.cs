using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquililbrium
{
    class Program
    {


        public int solution1(int[] A)
        {
            if(A.Length > 2)
            {
                List<int> result = new List<int>();
                int part1 = A[0];
                int part2 = A.Sum() - part1;
                result.Add(Math.Abs(part1 - part2));
                for (int i = 1; i < A.Length - 1; i++)
                {
                    part1 += A[i];
                    part2 -= A[i];

                    result.Add(Math.Abs(part1 - part2));
                }

                return result.Min();
            }

            return Math.Abs(A[0] - A[1]);
            
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { -10,-20,-30,-40,100};
            int answer = p.solution1(A);
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
