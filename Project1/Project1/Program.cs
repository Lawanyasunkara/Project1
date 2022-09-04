using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"F:\Data.txt");
            System.Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
