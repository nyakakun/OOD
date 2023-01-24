using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1
{
    public class TriangleShape : IShape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public TriangleShape(Point a, Point b, Point c) 
        {
            A = a; B = b; C = c;
        }
        public float GetArea()
        {
            throw new NotImplementedException();
        }

        public float GetPerimetr()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => $"A = {{{A}}}, B = {{{B}}}, C = {{{C}}}";
    }
}
