using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_OOP.FirstProject
{
    internal class Point3D : IComparable , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x , int y , int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(int x, int y) : this(x , y , 0) 
        {
            
            
        }

        public Point3D(int x) : this(x, 0, 0)
        {
           

        }
        public Point3D() : this(0, 0, 0) 
        { 
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D P =(Point3D) obj;


           
            if (this.X > P.X) return 1;
            if (this.X < P.X) return -1;

           
            if (this.Y > P.Y) return 1;
            if (this.Y < P.Y) return -1;

            
            if (this.Z > P.Z) return 1;
            if (this.Z < P.Z) return -1;

            
            return 0;
        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left.X == right.X)
            {
                if (left.Y == right.Y)
                {
                    return (left.Z == right.Z);
                }
            }
            return false;

        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left.X == right.X)
            {
                if (left.Y == right.Y)
                {
                    return (left.Z == right.Z);
                }
            }
            return false;

        }


    }
}
