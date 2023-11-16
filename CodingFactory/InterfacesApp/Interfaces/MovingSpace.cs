using InterfacesApp.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Interfaces
{
    internal class MovingSpace
    {
        /*
         readonly is like final in java
         */
        private readonly IMoveable moveable;

        // Dependency Injection, Inversion of Control (IoC)
        public MovingSpace(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public void MakeMove5()
        {
            moveable.Move5();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
