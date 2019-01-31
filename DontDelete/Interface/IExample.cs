using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontDelete.Interface
{

    //Interfaces can consist of public methods, properties and events(indexers are permitted too).
    //Interface can be declared public or internal

    //By default interface are public
    //Access modifiers in interface : there are no acces modifiers and are always public
    //Interface support multiple inheritance
    interface IExample
    {
        decimal GetCheckingBalance(long checkingAcctNum);
        decimal GetSavingBalance(long savingAcctNum);
        bool TransferCheckingToSaving(decimal amount, long checkingAccountNum, long savingAccountNum);


        //// method declaration
        //bool CheckSomething(object o);

        //// event declaration
        //event EventHandler ShapeChanged;

        //// Property declaration:
        //string Name
        //{
        //    get;
        //    set;
        //}



        //How to implement interface property into the class
        //In the interface, you specify the property:

        //public interface IResourcePolicy
        //        {
        //            string Version { get; set; }
        //        }
        //        In the implementing class, you need to implement it:

        //public class ResourcePolicy : IResourcePolicy
        //        {
        //            public string Version { get; set; }
        //        }
        //    }

    }
}

