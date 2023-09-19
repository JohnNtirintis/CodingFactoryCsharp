using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritApp.Model
{
    internal class Point
    {

        public int X {  get; set; }

        // static factory
        public static Point GetPoint()
        {
            return new Point();
        }

        // Virtual == Overridable
        public virtual void Move5()
        {
            X += 5;
        }

        public override string ToString()
        {
            return $"X = {X}";
        }
    }
}
