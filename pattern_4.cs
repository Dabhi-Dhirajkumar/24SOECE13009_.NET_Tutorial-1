using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class pattern_4
    {
        static void Main(string[] args)
        {
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
    }
}
