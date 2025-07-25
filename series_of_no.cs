using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class series_of_no
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input number: ");
            int digit = int.Parse(Console.ReadLine());


            int term = 0, sum = 0;
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                Console.Write(term);
                if (i < n)
                    Console.Write(" + ");
                sum += term;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is: " + sum);
        }
    }
}
