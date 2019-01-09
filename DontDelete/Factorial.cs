using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class Factorial
    {

        static void Ma(string[] args)
        {
            Console.WriteLine("Factorial Program");
            Console.WriteLine("Please enter the factorial of a number");
            string input = Console.ReadLine();

            int num = int.Parse(input);
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;

            }

            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
