using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class toggle_case
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string result = "";

            foreach (char ch in input)
            {
                if (char.IsUpper(ch))
                    result += char.ToLower(ch);
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);
                else
                    result += ch;
            }

            Console.WriteLine("Toggle Case: " + result);
        }
    }
}
