using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Tommy", "John", "Hans", "Michael" };

            foreach (string name in names) 
            {
                Console.WriteLine(name);
                Console.WriteLine(name.Length);

            }

            Console.ReadLine();

        }
    }
}
