using System;
using VectorLib;

namespace VectorApp
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Vector v1 = new Vector(1, 2);
            Vector v2 = new Vector(3, 4);
            Vector v3 = new Vector(v2);

          
            Vector v2Scaled = v2 * 2;


            Vector result = Vector.Subtract(v3, v2);

            Console.WriteLine("v1: " + v1.GetInfo());
            Console.WriteLine("v2: " + v2.GetInfo());
            Console.WriteLine("v3 (copy v2): " + v3.GetInfo());

            Console.WriteLine("\nv2 * 2 = " + v2Scaled.GetInfo());

            Console.WriteLine("v3 - v2 = " + result.GetInfo());

            Console.WriteLine("length v1: " + v1.Length());
        }
    }
}