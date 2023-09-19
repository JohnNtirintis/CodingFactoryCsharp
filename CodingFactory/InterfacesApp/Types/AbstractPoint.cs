using InterfacesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Types
{
    internal abstract class AbstractPoint : IMoveable
    {
        public int X { get; set; }
        public virtual void Move5()
        {
            X = +5;
        }

        public virtual void Move10()
        {
            X += 10;
        }
    }
}
