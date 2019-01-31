using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.ObjectParentDerived
{
    class ObjectInterfaceBase
    {


    }
    interface IAnimal
    {
        void characters(int height);
    }

    class Dog : IAnimal
    {
        int samp = 1;
        public void characters(int height)
        {
            Console.WriteLine("This is a derived class {0}", height);
        }


        static void Ma(string[] args)
        {

            Console.WriteLine("ObjectInterfaceBase Program");


            // only it cannot call the deried class field
            // Also, interface doesn't accept the fields.
            // de.samp = 43;
            // It is a good practise to use this pattern but I don't know the reason
            IAnimal de = new Dog();
            de.characters(24);


            //normal
            Dog sd = new Dog();
            sd.characters(42);
            
            Console.ReadLine();
        }

    } 
}
