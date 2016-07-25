using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProgrammingLanguages = new List<string>();
            ProgrammingLanguages.Add("R");
            ProgrammingLanguages.Add("Python");
            ProgrammingLanguages.Add("Ruby");
            ProgrammingLanguages.Add("C#");
            ProgrammingLanguages.Add("PHP");

            foreach (var Language in ProgrammingLanguages)
            {
                Console.WriteLine(Language + " ");
            }
            Console.ReadLine();
            //The output will be all the languages
        }
    }
}
