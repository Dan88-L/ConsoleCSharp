using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class Palindrome
    {
        static void Ma(string[] args)
        {
            Console.WriteLine("Palindrome Program");
            Console.WriteLine("Please enter the string");
            string tesu = Console.ReadLine();

            char[] array = tesu.ToCharArray();

            Array.Reverse(array);

            string rev = new string(array);

            Console.WriteLine(rev);

            if (tesu == rev)
            {
                Console.WriteLine("It is a palindrome");
            }
            else
            {
                Console.WriteLine("It is not a palindrome");
            }

            Console.ReadLine();


            //other way of finding comparing the string with Equals method
            /*
             
            bool b = tesu.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + tesu + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + tesu + " is not a Palindrome!");
            }

            Console.ReadLine();
            */

        }
    }
}
