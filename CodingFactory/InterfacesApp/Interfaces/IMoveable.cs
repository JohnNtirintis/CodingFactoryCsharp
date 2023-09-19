using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Interfaces
{
    internal interface IMoveable
    {
        // it's abstract by default
        abstract void Move5();

        // Default Implementation
        void Move10()
        {
            Console.WriteLine("Moved 10 units.");
        }
    }
}
