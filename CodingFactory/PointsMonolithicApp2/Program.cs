using PointsMonolithicApp2.Model;

namespace PointsMonolithicApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new() { X = 1 };
            Point p2 = new() { X = 2 };
            Point p3 = new() { X = 3 };

            p1.InsertPoint();
            p2.InsertPoint();
            p3.InsertPoint();

            p3.DeletePoint();
            p2.UpdatePoint(new Point() { X = 60 });

            foreach (Point p in Point.GetAllPoints())
            {
                Console.WriteLine(p);
            }
        }
    }
}