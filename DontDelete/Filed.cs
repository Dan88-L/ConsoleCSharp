using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace DontDelete
{
    class ABC
    {
        string temp;
        public string Temp
        {
            get { return temp; }

            set
            {
                if (value == string.Empty || value == " ")
                {

                    throw new ArgumentNullException();
                }
                else
                {
                    temp = value;
                }
            }
        }

        string firstName;

        public string FirstName
        {
            get { return firstName; }

            set
            {
                if (value == string.Empty || value == " ")
                {
                    
                    throw new ArgumentNullException();
                }
                else
                {
                    firstName = value;
                }
            }
        }

        int num;
        public int Num {
            get {
                return num;
            }
            set {
                if (value> 90)
                {
                    num = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }


    class Filed
    {
      
        public static void Ma(string[] args)
        {
            Console.WriteLine("Filed Program Checkup:");
            
            ABC a = new ABC();

            //Console.WriteLine("Please enter the email Address");
            //a.email = Console.ReadLine();
            //while (a.email == string.Empty || a.email == " ")
            //{
            //    Console.WriteLine("Please enter the email Address, it cannot be left emptty and is mandatory");
            //    a.email = Console.ReadLine();
            //}

            Console.WriteLine("Please enter the First Name");
            a.Temp = Console.ReadLine();
            a.FirstName = a.Temp;
            Console.WriteLine(a.FirstName);


            var currentDate = new DateTime();
            Console.WriteLine(currentDate.TimeOfDay);


            Console.WriteLine("Please any number");
            a.Temp = Console.ReadLine();
            a.Num = int.Parse(a.Temp);
            Console.WriteLine(a.Num);



            Console.ReadLine();
        }
    }

}