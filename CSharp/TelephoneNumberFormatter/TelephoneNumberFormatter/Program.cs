using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace TelephoneNumberFormatter
{
    class Program
    {

        public string solution(string S)
        {
            string retVal = "";
            string s = Regex.Replace(S, "[^0-9]", "");
            StringBuilder sb = new StringBuilder();

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int length = s.Length;
            int max3 = length % 3;
            int rem = length % 3;

            if (length > 3)
            {
                
                if (rem == 1)
                {
                    for (int i = 0; i < (length - 4); i++)
                    {
                        if ((i) % 3 == 0 && i != 0)
                        {
                            sb.Append('-');
                        }
                        sb.Append(s[i]);
                    }
                    int count = 0;
                    for (int j = length - 4; j < length; j++)
                    {
                        if (count % 2 == 0 && j != 0)
                        {
                            sb.Append('-');
                        }
                        count++;
                        sb.Append(s[j]);
                    }
                }
                else
                {
                    for (int i = 0; i < (length - rem); i++)
                    {
                        if ((i) % 3 == 0 && i != 0)
                        {
                            sb.Append('-');
                        }
                        sb.Append(s[i]);
                    }
                    int count = 0;
                    for (int j = length - rem; j < length; j++)
                    {
                        if (count % 2 == 0)
                        {
                            sb.Append('-');
                        }
                        count++;
                        sb.Append(s[j]);
                    }
                }

            }
            else
            {
                return s;
            }


            retVal = sb.ToString();
            return retVal;

        }


        static void Main(string[] args)
        {
            Program p = new Program();
            string answer = "";
            answer = p.solution("00-44555..");

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
