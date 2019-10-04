using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String:");
            string s = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Reversing the string using Split & Reverse function:");
            Console.WriteLine(string.Join(" ", s.Split(' ').Reverse()));
            Console.WriteLine("\n");
            Console.WriteLine("Reverse the string without spilt and reverse function:");
            string ReverseValue=ReverseWords(s);
            Console.WriteLine(ReverseValue);

            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            string output =string.Empty;
            string word = string.Empty;
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    output = word + ' ' + output;
                    word = string.Empty;
                }
                else
                {
                    word = word + c;
                }
            }
            output = word + ' ' + output;
            return output;
        }

    }
}
