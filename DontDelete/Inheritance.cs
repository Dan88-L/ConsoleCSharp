using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    public class Den
    {
        private int teri;
        public int teci;
        protected int lim;

    }

    public class Inheritance : Den
    {
        static void Ma(string[] args)
        {
            Console.WriteLine("Inheritance");
            Inheritance se = new Inheritance(); // Object of the class be instantiated inside its own methods 
            Console.WriteLine(se.easy());
            Console.ReadLine();

        }
        public int easy()
        {
            return 1;

        }

    }
}