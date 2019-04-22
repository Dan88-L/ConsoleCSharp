using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Algorithms.ForLoopsExcercise
{
    class Exercise2
    {

        static void M(string[] args)
        {

            List<int> de = new List<int>();

            Console.WriteLine("Algorithms: ForLoopsExercise: Exercise2: Reverse String Program");

            //Reversing the string using the for loop
            char[] res = new char[] { 'D', 'E', 'N', 'I', 'L' };

            char[] temp = new char[res.Count()];

            for (int i = 0; i < res.Count(); i++)
            {
                for (int j = (res.Count() - 1) - i; j >= 0; j--)
                {
                    temp[j] = res[i];
                    Console.WriteLine(temp[j]);
                    break; // break statement terminates the closest enclosing loop or switch statement
                }
            }

            Console.WriteLine("Outside the loop");
            Console.WriteLine("{0} {1} {2} {3} {4}", temp[0], temp[1], temp[2], temp[3], temp[4]);

            Console.ReadLine();

        }
    }
}
