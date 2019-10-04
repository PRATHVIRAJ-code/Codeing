using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<String> myStringList = new List<string>();
            string[] a = { "this","is","test","is","to","test" };
            string[] b = a.Distinct().ToArray();
            foreach (string s in b)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
