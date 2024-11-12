using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string input=Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(input[k]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
