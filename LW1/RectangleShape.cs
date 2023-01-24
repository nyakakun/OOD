using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1
{
    public class RectangleShape : IShape
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }
        public RectangleShape(Point a, Point b, Point c, Point d)
        {
            A = a; B = b; C = c; D = d;
        }
        public float GetArea()
        {
            int AB = Math.Abs(A.X == B.X ? A.Y - B.Y : A.X - B.X);
            int BC = Math.Abs(C.X == B.X ? C.Y - B.Y : C.X - B.X);
            return AB * BC;
        }

        public float GetPerimetr()
        {
            int AB = Math.Abs(A.X == B.X ? A.Y - B.Y : A.X - B.X);
            int BC = Math.Abs(C.X == B.X ? C.Y - B.Y : C.X - B.X);
            return AB * 2 + BC * 2;
        }

        public override string ToString() => $"A = {{{A}}}, B = {{{B}}}, C = {{{C}}}, D = {{{D}}}";
    }
}
