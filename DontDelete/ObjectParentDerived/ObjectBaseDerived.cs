using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.ObjectParentDerived
{

    class ObjectBaseDerived
    { 
        
    }

    class PQRBase
    {
        public int samp = 1;
        // case 1
        // Prints hello at this case
        //public void Print()
        //{
        //    Console.WriteLine("Hello");
        //}
         //case 2
        public virtual void Print()
        {
            Console.WriteLine("Hello");
        }
    }

    class PQRDerived : PQRBase
    {

        public int camp = 2;
        // case 1
        //public void Print()
        //{
        //    Console.WriteLine("Hi");    
        //}

        // case 2
        // prints hi
        public override void Print()
        {
            Console.WriteLine("Hi");
        }

        static void Ma(string[] args)
        {
            Console.WriteLine("ObjectParentDerived: XYZ Program ");
            PQRBase d1 = new PQRBase(); 
            d1.Print();   // print hello


            PQRDerived p1 = new PQRDerived();
            p1.Print();  //print hi
            p1.samp = 43; // Also derived object can point to any of the base members and methods execpt private

            // Suitable for interface and derived class
            // Actually it points the base class always whether its field or methods
            // When declaring this type of statement, always method has to be in both parent and derived.
            // Now - same method, confusion which method will be called?
            // if overiride in the derived class then it prints derived if not prints base
            // you know about interface


            // Suitable to use in iterface as base and class as derived
            // Below example is only for class to class

            PQRBase x1 = new PQRDerived();
            x1.Print();
           
            
            // if the other way round derived class to  base class then please look in other module of
            //https://stackoverflow.com/questions/10104180/access-the-base-class-method-with-derived-class-objects

            Console.ReadLine();
        }

    }
}
