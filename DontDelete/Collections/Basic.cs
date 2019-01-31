using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Collections
{
    class Basic
    {

        static void Ma(string[] args)
        {
            Console.WriteLine("Collections: Basic Program");

            //Difference between count and length, it is a property of an array object
            //Length: Total number of elements in an array
            //Count(): LINQ extension method that works with other collection types as well, for no confusion it's better to use count in every
            

            //List:
            //1. Add
            List<int> se = new List<int>();
            se.Add(23);
            se.Add(42);
            se.Add(43);
            se.Add(44);
            for (int i = 0; i < se.Count(); i++)
            {
                se[i] = se[i] + 2;
            }

            foreach( var a in se)
            {
                Console.WriteLine(a);
            }

            //2. Remove
            se.Remove(44); // Remove the element inside the list
            Console.WriteLine("After removing");
            foreach (var a in se)
            {
                Console.WriteLine(a);
            }

            //3. Clear:
            //Console.WriteLine("After Clear");
            //se.Clear();

            //foreach (var a in se)
            //{
            //    Console.WriteLine(a);
            //}


            //4. insert
            Console.WriteLine("After Insert");
            se.Insert(2,72);

            foreach (var a in se)
            {
                Console.WriteLine(a);
            }

            //4. Contains
            Console.WriteLine("Search if it contains");
            Console.WriteLine(se.Contains(45));


            // 5. Sort
            Console.WriteLine("After Sorting");
            se.Sort();

            foreach (var a in se)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("After Removing at particular");
            se.RemoveAt(2);

            foreach (var a in se)
            {
                Console.WriteLine(a);
            }


            Console.ReadLine();
        }
    }
}
