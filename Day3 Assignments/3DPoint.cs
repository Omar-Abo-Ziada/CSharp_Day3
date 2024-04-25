using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignments
{
    internal class _3DPoint : IComparable<_3DPoint> , ICloneable
    {
        private int _x, _y, _z;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
        //public int X { get; set; }
        //public int Y { get; set; }
        //public int Z { get; set; }
        public _3DPoint(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        public void Display()
        {
            Console.WriteLine($"x = {_x} \t  y = {_y} \t  z = {_z} ");
        }
        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            if (p1._x == p2._x && p1._y == p2._y && p1._z == p2._z)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {
            if (p1._x != p2._x || p1._y != p2._y || p1._z != p2._z)
            {
                return true;
            }
            return false;
        }
        public void ChangeCoordinates(int newX, int newY, int newZ)
        {
            _x = newX;
            _y = newY;
            _z = newZ;
        }
        public override string ToString()
        {
            return $"this point coordinates is = ( {_x} , {_y} , {_z} ) .";
        }
        public override bool Equals(object obj)
        {
            if (obj is _3DPoint)
            {
                _3DPoint p = obj as _3DPoint;

                if ((_x == p._x) && (_y == p._y) && (_z == p._z))
                    return true;

                return false;
            }
            throw new Exception("This is not a 3dPoint Object !");
        }
        public static void Display3DPointsArr(_3DPoint[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i].ToString());
                //Console.WriteLine(points[i].Display());
            }
        }
        public int CompareTo(_3DPoint p)
        {
            if ((_x > p._x) && (_y > p._y) && (_z > p._z))
                return 1;

            if ((_x < p._x) && (_y < p._y) && (_z < p._z))
                return -1;

            return 0;
        }
        public object Clone()
        {
            return new _3DPoint(_x, _y, _z);
        }

    }
}
