using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[] {1,2,3,4,5,6,7,8,9};
            foreach(int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.ReadLine();
        }
    }
}
