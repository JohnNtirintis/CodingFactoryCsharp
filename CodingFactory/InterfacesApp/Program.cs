using InterfacesApp.Interfaces;
using InterfacesApp.Types;

namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable moveable = new Point2D
            {
                X = 10,
                Y = 20
            };

            moveable.Move10();
            Console.WriteLine(moveable);

            MovingSpace movingSpace1 = new(moveable);
            movingSpace1.MakeMove5();
            Console.WriteLine(movingSpace1);
        }
    }
}