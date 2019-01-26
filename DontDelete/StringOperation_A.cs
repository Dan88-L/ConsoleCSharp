using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class StringOperation_A
    {
        static void Ma(String[] args)
        {
            Console.WriteLine("String Operations Program");

            //Console.WriteLine("Please enter the string");
            //String alpha = Console.ReadLine();

            // Initialize to null.
            string message2 = null;

            // Initialize as an empty string.
            // Use the Empty constant instead of the literal "".
            string message3 = System.String.Empty;

            // Converting string into character array
            string message4 = "It is an empty string";
            char[] convert_message4 = message4.ToCharArray();

            // Array's declaration
            // In c, it is: int de[] = {1, 2, 3};
            // it is of 32 bits
            // It is a signed integer accepting both positive and negative
            int[] example_1 = { 1, 2, -3 };

 
            // It is a unsigned integer accepting only positive integers
            uint[] example_2 = new uint[] { 2, 4, 5 };

            // when fixed type of array is needed
            int[] example_3 = new int[3] { 1, 2, 3, };


            //It is int64 with 64 bits
            // Likewise C# family has short, ushort, sbyte, byte, ulong
            long[] example_4 = { 210987, 437890 };


            // The suffix f has to be typed as f or F to become a float orelse c# compliler will treat as double
            // It is 32 bits
            float[] example_6 = { 2.06f, 2.09f, 4.0f };


            // It is 64 bits with suffix D or without
            // Everything with points number are treated as double in c# if suffix in not mentioned
            double[] example_7 = { 2, 3.01D, 42.89 };


            //It is 128 bits with suffix M if not points values will be treated as double
            decimal[] example_8 = { 22.09M, 89, 789.21M };

            char[] example_5 = { '0', '2', '@' };


            // It is an string array
            string[] limbu = { "denil", "limbu", "is a good boy" };


            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);


            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
            //Console.WriteLine(limbu[0]);
 
            Console.ReadLine();

        }

    }
}