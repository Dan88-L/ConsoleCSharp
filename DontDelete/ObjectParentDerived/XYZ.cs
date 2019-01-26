using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.ObjectParentDerived
{
    class XYZ
    {
        // case 1
        // Prints hello at this case
        public virtual void Print()
        {
            Console.WriteLine("Hello");
        }


        // case 2
        //public virtual void Print()
        //{
        //    Console.WriteLine("Hello");
        //}
    }


    class PQR : XYZ
    {
        // case 1
        public void Print()
        {
            Console.WriteLine("Hi");

        }

        // case 2
        // prints hi
        //public override void Print()
        //{
        //    Console.WriteLine("Hi");

        //}

        static void Ma(string[] args)
        {
            Console.WriteLine("ObjectParentDerived: XYZ Program ");
            XYZ d1 = new XYZ(); 
            d1.Print();   // print hello


            PQR p1 = new PQR();
            p1.Print();  //print hi


            // if overiride in the derived class then it prints derived if not prints base
            XYZ x1 = new PQR();
            x1.Print();

            // if the other way round derived class to  base class then please look in other module of

            //https://stackoverflow.com/questions/10104180/access-the-base-class-method-with-derived-class-objects

            Console.ReadLine();
        }

    }
}
