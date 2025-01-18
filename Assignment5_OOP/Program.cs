using System.Drawing;
using Assignment5_OOP.FirstProject;
using Assignment5_OOP.SecondProject;
using Assignment5_OOP.ThirdProject;

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

            #region Second Project
            // Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide,
            // each of them takes two parameters. Call each method in Main ().
            // Modify the program so that you do not have to create an instance of class to call the four methods.




            // Before Modifing
            //Maths maths = new Maths();
            //Console.WriteLine($" Add : {maths.Add(1, 2)}");
            //Console.WriteLine($" Subtract : {maths.Subtract(4, 3)}");
            //Console.WriteLine($" Multiply : {maths.Multiply(2, 3)}");
            //Console.WriteLine($" Divide : {maths.Divide(10, 5)}");

            // Afer Modify
            //try
            //{
            //    Console.WriteLine($" Add : {Maths.Add(1, 2)}");
            //    Console.WriteLine($" Subtract : {Maths.Subtract(4, 3)}");
            //    Console.WriteLine($" Multiply : {Maths.Multiply(2, 3)}");
            //    Console.WriteLine($" Divide : {Maths.Divide(10, 5)}");
            //}
            //catch( Exception e )
            //{
            //    Console.WriteLine(e.Message );
            //}


            #endregion

            #region Third Project

            // 1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            // 2.Override All System.Object Members (ToString, Equals,GetHasCode) .
            // 3.Define All Required Constructors to Produce this output: 
            //Duration D1 = new Duration(1, 10, 15);
            //D1.ToString();
            //Output: Hours: 1, Minutes: 10, Seconds: 15

            //Duration D1 = new Duration(3600);
            //D1.ToString();
            //Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //D2.ToString();
            //Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //D3.ToString();
            //Output: Minutes: 11, Seconds: 6

            // 4.Implement All required Operators overloading to enable this Code:
            //D3 = D1 + D2
            //D3 = D1 + 7800
            //D3 = 666 + D3
            //D3 = ++D1(Increase One Minute)
            //D3 = --D2(Decrease One Minute)
            //D1 = D1 - D2
            //If(D1 > D2)
            //If(D1 <= D2)
            //If(D1)
            //DateTime Obj = (DateTime)D1

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString()); 

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString()); 

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString()); 

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());


            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(2, 20, 19);
            Duration D3 = null;

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = D1++;
            D3 = --D2;
            D1 = D2 - D1;

            if(D1)
            {

            }
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString());
            #endregion
        }
    }
}
