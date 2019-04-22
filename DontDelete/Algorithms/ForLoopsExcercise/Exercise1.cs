using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Algorithms.ForLoopsExcercise
{
    class Exercise1
    {
        static void Ma(string[] args)
        {

            Console.WriteLine("Algorithms: ForLoopsExercise: Exercise1: Normal For Loop program");

            //this is a normal behavior of two for loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Damian Edwards");
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Scott Hunter");
                }
            }

            //this is a normal behaviour of two for loops but in a decrementing way
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("Damian Edwards");
                for (int j = 5; j > 0; j--)
                {
                    Console.WriteLine("Scott Hunter");
                }
            }


            Console.ReadLine();

        }
    }
}
