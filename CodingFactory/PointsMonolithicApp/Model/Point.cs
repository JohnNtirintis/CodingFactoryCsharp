using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsMonolithicApp.Model
{
    internal class Point 
    {

        public int X {  get; set; }

        private static readonly IList<Point> _points = new List<Point>();
        
        public bool? Equals(Point? other)
        {
            if(other is null)  return false;
            // return CompareTo(other) == 0;
            return null;
        }

        /*
         * CRUD API
         */
        public void Insert()
        {

        }

        public bool? Update(Point? point)
        {
            int positionToUpdate = GetPointPosition();
            if (positionToUpdate == -1) return null;
            _points[positionToUpdate] = point!;
            return true;
        }

        public Point? Delete()
        {
            int positionToDelete = GetPointPosition();
            if (positionToDelete == -1) return null;
            Point? pointToReturn = _points[positionToDelete];
            _points.Remove(this);
            return pointToReturn;                
            
        }


        public Point? GetPointOrNull()
        {
            return _points.Contains(this) ? _points[GetPointPosition()] : null;
        }

        private int GetPointPosition()
        {
            return _points.IndexOf(this);
        }

        // Service API
        public void InsertPoint()
        {
            // Means this.insert()
            Insert();
        }

        public Point? UpdatePoint(Point? point)
        {
            if(Update(point)) return null;
        }

        public Point? DeletePoint()
        {
            return Delete();
        }

        public Point? GetPoint()
        {
            return GetPointOrNull();
        }

        public List<Point> GetAllPoints()
        {
            return new List<Point>(_points);
        }
    }
}
