using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k;
            string input = "program";
            int len = input.Length;
            string temp = input;
            for(i=0;i<len;i++)
            {
                j=len-1-i;
                for (k = 0; k < len; k++)
                {
                    if (i == k || j == k)
                    {
                        Console.Write(input[k]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
