using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rondom numbers do you want to create?");
            int numberCount = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine("{0}. random number : {1}", (i + 1), random.Next(101));
            }

            Console.ReadKey(); 

        }
    }
}
