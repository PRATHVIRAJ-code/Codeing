using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] c = new int[(int)char.MaxValue];
            Console.WriteLine("Enter the String:");
            string s = Console.ReadLine();
            foreach (char t in s)
            {
                c[(int)t]++;
            }
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 &&
                    char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("{0} : {1}",
                        (char)i,
                        c[i]);
                }
                else if(c[i] > 0 && char.IsWhiteSpace((char)i))
                        {
                    Console.WriteLine("'' : {1}",
                       (char)i,
                       c[i]);
                }
                else if (c[i] > 0 && char.IsPunctuation((char)i) || c[i] > 0 && char.IsSymbol((char)i))
                {
                    Console.WriteLine("{0} : {1}",
                       (char)i,
                       c[i]);
                }

            }
            Console.ReadLine();

        }
    }
}
