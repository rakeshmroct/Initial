using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public struct Rectangle
    {
        public double Length { get; }
        public double Height { get; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    public class Triangle
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }

    class _21PatternMatching
    {
        public static double ComputeArea(object shape)
        {
            if (shape is Square)
            {
                var s = (Square)shape;
                return s.Side * s.Side;
            }
            else if (shape is Circle)
            {
                var c = (Circle)shape;
                return c.Radius * c.Radius * Math.PI;
            }
            // elided
            throw new ArgumentException(
                message: "shape is not a recognized shape",
                paramName: nameof(shape));
        }
    }
}
