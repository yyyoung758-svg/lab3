using System;

namespace VectorLib
{
    public class Vector
    {
        private double x, y;


        public double X => x;
        public double Y => y;

    
        public Vector()
        {
            x = 0;
            y = 0;
        }

    
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

    
        public Vector(Vector other)
        {
            x = other.x;
            y = other.y;
        }


        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }


        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }


        public static Vector operator *(Vector v, double k)
        {
            return new Vector(v.x * k, v.y * k);
        }


        public static Vector Subtract(Vector first, params Vector[] others)
        {
            double resX = first.x;
            double resY = first.y;

            foreach (var v in others)
            {
                resX -= v.x;
                resY -= v.y;
            }

            return new Vector(resX, resY);
        }

   
        public string GetInfo()
        {
            return $"({x}, {y})";
        }
    }
}