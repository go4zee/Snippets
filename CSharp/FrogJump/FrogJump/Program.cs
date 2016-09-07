using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump
{
    class Program
    {
        public int solution(int X, int Y, int D)
        {
            int retVal = 0;

            if ((Y - X) % D == 0)
                retVal = (Y - X) / D;
            else
                retVal = ((Y - X) / D) + 1;


            return retVal;
        }
        static void Main(string[] args)
        {
        }
    }
}
