using InterfacesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Types
{
    // Extends abstractpoint and implements IMoveable
    internal class Point : AbstractPoint, IMoveable
    {
        public override string? ToString()
        {
            return $"X: {X}";
        }
    }
}
