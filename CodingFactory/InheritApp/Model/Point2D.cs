using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritApp.Model
{
    internal class Point2D : Point
    {
        public int Y { get; set; }

        public override void Move5()
        {
            base.Move5();
            Y += 5;
        }
    }
}
