using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class Field_Property
    {

        // private field
        private int date;

        // public field (Generally not recommended.)
        public string day;

        // Public property exposes date field safely.
        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                try { 
                        // Set some reasonable boundaries for likely birth dates.
                        if (value > 1900 && value <= 2020)
                        {
                            date = value;
                        }
                
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                }
                catch(Exception e) {

                    //Console.WriteLine("There is an exception of  type:{0}", e);
                    throw e;
                }
            }

        }
    }


    class Tryout
    {
        static void Ma(string[] args)
        {
            Console.WriteLine("Field_Property Program");


            Field_Property fg1 = new Field_Property();
            Field_Property fg2 = new Field_Property();
            fg1.Date = 2019;

            Console.WriteLine("Plase enter the year of the date:");

            // this will throw an error becuase of public property safely uses the field with condition
            fg2.Date = int.Parse(Console.ReadLine());


            Console.WriteLine(fg2.Date);

            Console.ReadLine();
        }
    }

}