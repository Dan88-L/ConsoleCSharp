using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Constructor
{
    class UGStudent
    {
        public int id;

        public int test1;

        public string Firstname { get; set; }

        public UGStudent()
        {

        }

        public UGStudent(string fname, int id, int t1)
        {
            Firstname = fname;
            this.id = id;
            test1 = t1;
        }


        static void Ma(string[] args)
        {

            Console.WriteLine("Constructor Folder: UGStudent Program");
            // Below statement will be valid if there is no any constructor becuase c# will give you the default constructor
            // If there are parameterized constructor then always declare one default constructor or else below statement won't be valid
            UGStudent ug1 = new UGStudent();

     

            UGStudent ug2 = new UGStudent("Limbu", 25, 32);

            Console.WriteLine(ug2.Firstname);

       
            Console.ReadLine();

            // we can write as many constructors inside a classs as long as number or type of paramters is different
            // constrcutor has the same name as the class. So the technical term in this scenario is the overloading.
        }

    }

}
