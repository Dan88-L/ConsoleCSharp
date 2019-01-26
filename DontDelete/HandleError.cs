using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete
{
    class HandleError
    { 
        // User created Exception
        public class ClientBillingException : Exception
        {
            public ClientBillingException(string message)
               : base (message)
            {
            }
        }

        public void multiply (int num1, int num2)
        {
            try
            {
                throw new ClientBillingException(string.Format("Unable to find a client by id {0}", 123456));
            }
            catch (ClientBillingException e)
            {
                Console.WriteLine("There is an exception: {0}", e);   
            }
        }

        public void division (int num1, int num2)
        {

            // in the try catch if anything happen then automatically it detects in the try block and throws the exception 
            // that throw excpetion is then catched in the catch block.
            // Only if you know that particular exception or user defined exception then use throw statement.
            try
            {   
                int result = num1 / num2;
                //throw new ArgumentNullException(); 
            }

            // if you do not know any particular exception then just declare it Exception
            // Write a proper message, so that the user knows where exactly the system went wrong
            catch (Exception e)
            {
                Console.WriteLine("There is an exceptions: {0}", e);
            }
        }

        public static void Ma(string[] args)
        {

            HandleError he = new HandleError();
            he.division(25, 0);
            Console.ReadLine();
        }
    }
}
