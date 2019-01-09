using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DontDelete
{
    class StringOccurence
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String Occurence Program");
            string s1 = "Sam's first name is Sam.";

            //string myString = "OU=Level3,OU=Level2,OU=Level1,DC=domain,DC=com";

            int count = Regex.Matches(s1, "Sam").Count;

            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
