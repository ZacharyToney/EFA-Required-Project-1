using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test;
            test = (2 > 1) ? true : false;
            Console.WriteLine(test);

            int a = 1;
            int b = 2;
            if (a > b)
            {
                Console.WriteLine("I guess 1 is greater then 2 now.");
            }
            else
            {
                Console.WriteLine("2 has always been greater then 1");
            }
            Console.ReadLine();
        }
    }
}
