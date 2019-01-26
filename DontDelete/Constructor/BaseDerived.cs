using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Constructor
{
    public class BaseDerived
    {

    }

    public class BaseClass
    {
        public int num;

        public string fname, lname;

        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }


    // When inheritance, in base if you have a constructor but not default
    // you cannot inherit until you have default becuase when you inherit
    // at later stage  when calling the derived classs constructor the compiler calls the empty base class constructor, so
    public class DerivedClass : BaseClass
    {
        public int num2;
        // This constructor will call BaseClass.BaseClass()
        // Then also calls the derived class constructor.
        public DerivedClass() : base()
        {

        }

        // This constructor will call BaseClass.BaseClass(int i)
        // It just means that, you donn't have to declare any new instances in the derived class if it is already in the base class
        // Meaning, num2 declaring is just a waste becuase it's the same value
        public DerivedClass(int i) : base(i)
        {
            num2 = i;
        }

        public DerivedClass(string fname, string lname)
        {

        }

        static void Main(string[] args)
        {

            Console.WriteLine("BaseDerived Program: It shows the constructor of Base and derived class");
            DerivedClass md = new DerivedClass(1);
            Console.WriteLine(md.num);
            Console.WriteLine(md.num2);

            DerivedClass md1 = new DerivedClass("denil", "limbu");

            Console.WriteLine(md1.fname);


            Console.ReadLine();
        }
    }
}