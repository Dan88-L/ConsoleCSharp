using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Lmbuden;

namespace DontDelete.USEDLL
{
    class UseLmbuDLL
    {
        public static void Main()
        {
            // Always the class libraries are used in a point entry system or something like that in a controller
            // this dll helps to connect and retrieve if used properly with a constring
            // Have to create a documentation for the proper use.

            DataAccess cat = new DataAccess();

        }
    }

}