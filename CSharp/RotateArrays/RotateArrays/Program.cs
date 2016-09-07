using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrays
{
    class Program
    {
        public int[] solution(int[] A ,int K)
        {
            int[] retVal = null;

            if (A.Length > 0)
            {

                for(int i=0;i<K;i++)
                {
                    A = RotateRightByOne(A);
                }
                /***
                Array.Reverse(A, 0, K+1);
                Array.Reverse(A, K + 1, A.Length - K - 1);
                Array.Reverse(A, 0, A.Length);

                retVal = A;
                ***/
            }
            retVal = A;
            return retVal;
        }

        public int[] RotateRightByOne(int[] arr)
        {
            int i, temp;
            int length = arr.Length;
            temp = arr[arr.Length-1];
            for(i = (length-1);i>0;i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0] = temp;

            return arr;

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] A = { 3,8,9,7,6 };
            int[] answer = p.solution(A,3);
            
            foreach(int i in answer)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
