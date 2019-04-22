using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Goto
{
    class Class1
    {
        static void Ma(string[] args)
        {
            Console.WriteLine("Goto: Class1 Program");
            int i = 0;

            goto check;
            loop: { 
            Console.WriteLine(i++);
            Console.WriteLine("a");
            }

            Console.WriteLine("This is b");
            check: {
                if (i < 6)
                {
                    goto loop;
                }
            }
            Console.WriteLine("End");
            Console.ReadLine();
        }


    }
}
