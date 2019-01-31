using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.FormatSpecifier
{
    class Sample
    {
        enum Color
        {
            Yellow = 0, Blue, Green
        }

        static void Ma(string[] args)
        {

            Console.WriteLine("Format Specifier: Sample Program");

            //Difference between Write() and WriteLine() is
            Console.Write("hello"); //will only simple print the required without any line at the end
            Console.WriteLine("This will print with \t a new line at the end"); // however this will print with a new line at the end with a tab

            // Enumeration in decimal example
            Console.WriteLine("{0:D}", Color.Green);


            Console.WriteLine("Difference between Read(), ReadLine(), ReadKey()");

            // Reads the next character from the standard input stream.
            // returns int32 The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.
            // so it has to be initialized to int32
            // in a program either read or reaLine can only be performe or else it reutrn anamolies.(denil's own findings)

            //int de = Console.Read();
            //Console.WriteLine(de);



            // Reads the next line of characters from the standard input stream
            // return string, The next line of characters from the input stream, or null if no more lines are available.
            //Console.WriteLine("Enter the string:");
            //string se = Console.ReadLine();
            //Console.WriteLine(se);




            //Readkey()
            //Obtains the next character or function key pressed by the user
            //Paramters determine whether to display key in the console window, true for not to display the pressed key; otherwise false
            Console.WriteLine("Enter anything");
            ConsoleKeyInfo ce = Console.ReadKey();
            Console.WriteLine(ce.Key);


            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
