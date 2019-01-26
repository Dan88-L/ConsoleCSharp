using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class StringOperation_B
    {

        static string test;
        static DateTime time;

        static void Ma(string[] args)
        {
            string firstname;
            string lastname;


            Console.WriteLine("Strig Operations B Program");

            //when string is declared but not assigned then it will be null
            Console.WriteLine(test == null ? "location is null" : test);

            // When value type DateTime not intialized, it is initialized to the default value of midnight
            // (yup, that’s the year 1 A.D.)
            Console.WriteLine(time == null ? "time is null" : time.ToString());

            //remember strings are double quoted
            firstname = "Steven Clark";
            lastname = "Clark";

 
            int de = 32;

            //Returns the Length of String
            Console.WriteLine(firstname.Length);
        

            Console.WriteLine(firstname.Clone());
            // Make String Clone


            Console.WriteLine(firstname.CompareTo(lastname));
            //Compare two string value and returns 0 for true and 1 for false and in our case it is false so reutrn 1
            //Please compare with .Equals


            //Compare two string and returns true and false
            Console.WriteLine(firstname.Equals(lastname));

            // Check whether specified value exists or not in string
            // In this case, it returns true
            Console.WriteLine(firstname.Contains("n C"));


            //Check whether specified value is the last character of string
            Console.WriteLine(firstname.EndsWith("k"));


            //Returns HashCode of String
            Console.WriteLine(firstname.GetHashCode());


            //Returns type of string
            Console.WriteLine(firstname.GetType());

            //Returns type of string
            Console.WriteLine(firstname.GetTypeCode());


            //Returns the first index position of specified value the first index position of specified value
            Console.WriteLine(firstname.IndexOf('e'));

            //Returns the last index position of specified value
            Console.WriteLine(firstname.LastIndexOf("e")); 

            //Covert string into lower case
            Console.WriteLine(firstname.ToLower());

            //Convert string into Upper case
            Console.WriteLine(firstname.ToUpper());


            // Insert substring into string
            // So only at this time it will insert the required but won't be permanent
            // So you should intialize it an empty string
            Console.WriteLine(firstname.Insert(0, "Hello"));

            test = firstname.Insert(0, "Hello");
            Console.WriteLine(test);

            //Check Whether string is in Unicode normalization from C
            Console.WriteLine(firstname.IsNormalized());


            // Deletes all the characters from pecified index to the end.
            Console.WriteLine(firstname.Remove(5));
            test = firstname.Remove(5);

            // Replace the character
            Console.WriteLine(firstname.Replace('e', 'i'));



            // Split the string based on specified value
            string[] split = firstname.Split(new char[] { ' ' });


            Console.WriteLine(split.Count());
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);



            //Check wheter first character of string is same as specified value
            Console.WriteLine(firstname.StartsWith("s"));

            //Returns substring from first or if mentioned last index
            Console.WriteLine(firstname.Substring(2,5));



            //Converts an string into char array.
            Console.WriteLine(firstname.ToCharArray());
            char[] se = firstname.ToCharArray();
            Console.WriteLine(se[4]);



            //It removes starting and ending white spaces from string.
            string rm = "\t\t" + "denil" + "is a good boy";
            Console.WriteLine(rm);
            Console.WriteLine(rm.Trim());



            Console.ReadLine();

        }
    }
}