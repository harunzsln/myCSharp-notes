using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
     class Program
    {
        static void Main(string[] args)
        {
            /*
            int sum1 = 100;
            int sum2 = 20;
            int sum3 = sum1 + sum2;
            Console.WriteLine(sum3);
            */

            Console.WriteLine("Enter the first number : ");
            String num1Value = Console.ReadLine();

            int num1 = Convert.ToInt32(num1Value);

            Console.WriteLine("Enter the second number : ");
            String num2Value = Console.ReadLine();

            int num2 = Convert.ToInt32(num2Value);

            Console.WriteLine("The addition of two numbers is : {0}", num1 + num2);
            Console.WriteLine("the substraction of two numbers is : {0}", num1 - num2);
            Console.WriteLine("the multiplication of two numbers is : {0}", num1 * num2);
            Console.WriteLine("the division of two numbers is : {0}", num1 / num2);
            Console.WriteLine("the modus of two numbers is : {0}", num1 % num2);
            Console.WriteLine("the increment of first numbers is : {0}", (++num1));
            Console.WriteLine("the decrement of second numbers is : {0}", (--num2));

             Console.ReadKey();




        }
    }
}
