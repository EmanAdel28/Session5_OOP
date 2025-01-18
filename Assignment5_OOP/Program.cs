using System.Drawing;
using Assignment5_OOP.FirstProject;

namespace Assignment5_OOP
{
    internal class Program
    {
        static int ReadCoordinate(String CoordinateName)
        {
            Console.WriteLine($"Enter : {CoordinateName} ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }

            try
            {
                return int.Parse(input);
            }
            catch
            {
                return Convert.ToInt32(input);
            }
        }

        static Point3D ReadPoint()
        {
            int X = ReadCoordinate("x");
            int Y = ReadCoordinate("y");
            int Z = ReadCoordinate("z");

            return new Point3D(X, Y, Z);
        }
       
        static void Main(string[] args)
        {
            #region First Project
            //1. Define 3D Point Class and the basic Constructors (use chaining in constructors).
            //2. Override the ToString Function to produce this output:
            //Point3D P = new Point3D(10, 10, 10); 
            //Console.WriteLine(P.ToString());
            //Output: “Point Coordinates: (10, 10, 10)”.

            //3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //4. Try to use == If(P1 == P2)   Does it work properly? 
            //5. Define an array of points and sort this array based on X & Y coordinates.
            //6. Implement ICloneable interface to be able to clone the object To implement more than one interface.
            //class Point3D : IComparable, ICloneable

            //Point3D P = new Point3D(10);
            //Console.WriteLine(P.ToString());


            //Point3D P1 = ReadPoint();
            //Point3D P2 = ReadPoint();

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());


            //if (P1 == P2)  // Invalid i want to make  operator overload 
            //{
            //    Console.WriteLine("P1 == P2")
            // }

            // After Overloading Operator
            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 == P2");
            // }
            //else
            //{
            //    Console.WriteLine("P1 Not Equal P2");
            //}

            //      Point3D[] points = new Point3D[]
            //{
            //      new Point3D(3, 5, 2),
            //      new Point3D(1, 2, 8),
            //      new Point3D(3, 2, 4),
            //      new Point3D(2, 3, 7),
            //      new Point3D(0, 2, 6)
            //};
            //      Array.Sort(points);
            //      foreach(Point3D p in points)
            //          { Console.WriteLine(p.ToString()); }

            //Point3D P1 = new Point3D(1, 4, 3);
            //Point3D P2 = null;

            //P2 = (Point3D)P1.Clone();
            //Console.WriteLine(P2);
            
            #endregion
        }
    }
}
