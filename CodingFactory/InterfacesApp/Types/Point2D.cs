using InterfacesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Types
{
    internal class Point2D : AbstractPoint, IMoveable
    {
        public int Y { get; set; }

        // Move10 is virual so it can be overriden
        public override void Move10()
        {
            base.Move10();
            Y += 10;
        }

        // Again, move5 is virtual so it can be overriden
        public override void Move5()
        {
            base.Move5();
            Y += 5;
        }
    }
}
