using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        
        enum People { Tim,Jim };

        static void Main()
        {
            int x = (int)People.Tim;
            int y = (int)People.Jim;
            Console.WriteLine("Tim", x);
            Console.WriteLine("Jim", y);
            Console.ReadLine();
        }
    }
}
