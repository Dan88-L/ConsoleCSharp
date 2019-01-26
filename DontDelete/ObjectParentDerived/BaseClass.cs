using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.ObjectParentDerived
{
    public class BaseClass
    {
        public int denil;
        public void Method1()
        {
            string a = "Base method";
            Console.WriteLine(a);
        }

        public int cte()
        {

            return 1;
        }
    }

    public class DerivedClass : BaseClass
    {
        public int limbu;
        public new void Method1()
        {
            string a = "Derived Method";
            Console.WriteLine(a);
        }
    }

    public class TestApp
    {
        public static void Ma()
        {

            Console.WriteLine("ObjectParentDerived: BaseClass Program ");
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.Method1(); // it calls the derived class
            
            
            //(derivedObj as BaseClass).Method1(); // accessing the base class method with derived clas object



            BaseClass bg1 = new BaseClass();
            bg1.Method1(); // it calls the base class




            derivedObj.denil = 22;  //derived class object can call base class methods and members but not the other way round
            derivedObj.limbu = 32;
            Console.WriteLine(derivedObj.cte());
            Console.ReadLine();
          
        }
    }
}
