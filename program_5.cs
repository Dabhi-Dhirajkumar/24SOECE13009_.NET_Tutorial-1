using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13009_.NET_Tutorial_1
{
    internal class program_5
    {
        static void Main(string[] args)
        {
            int n, fact = 1; // int variable declare and fact initialize

            Console.WriteLine("Enter Number : "); // Asking the user to enter a number

            string str = Console.ReadLine(); // Reading user input

            n = Convert.ToInt32(str); // Converting the input string to integer 

            for (int i = 1; i <= n; i++) // Loop from 1 to 'n'
            {
                fact = fact * i; // display claculate factorial
            }

            Console.WriteLine("Factorial : {0}", fact); // display claculate factoorial
            Console.Read(); // wait for user to press the key before closing the console window
        }
    }
}
