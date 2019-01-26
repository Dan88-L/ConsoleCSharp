using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class OperationList
    {

        static void Ma(string[] args)
        {

            Console.WriteLine("OperationList Program");
            Console.WriteLine("Collection Generics Program:");

            List<int> le = new List<int>();

            le.Add(23);
            le.Add(43);
            le.Add(35);


            for (int i = 0; i < le.Count; i++)
            {
                le[i] = le[i] + 2;

            }

            foreach (int prime in le)
            {
                Console.WriteLine(prime);
            }


            Console.ReadLine();
        }
    }
}
