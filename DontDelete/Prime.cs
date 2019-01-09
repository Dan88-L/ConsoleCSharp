using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class Prime
    {

        static void Ma(string[] args)
        {
            Console.WriteLine("Prime Number");
            Console.WriteLine("Enter the number to find whether it is prime or not");
            string toCheck = Console.ReadLine();

            int num = int.Parse(toCheck);

            int a = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", num);
            }
            Console.ReadLine();

        }
    }
}
