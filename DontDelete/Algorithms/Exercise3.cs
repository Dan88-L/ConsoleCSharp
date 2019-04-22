using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Algorithms
{
    class Exercise3
    {

        static void Ma(string[] args)
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 67, 12, 19 };

            int last = numbers.Last(num => num > 80);

            Console.WriteLine(last);

            Console.ReadLine();
        }
    }
}
