using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW1
{
    public class CircleShape : IShape
    {
        public Point Center { get; }
        public int Radius;
        public float GetArea()
        {
            throw new NotImplementedException();
        }

        public float GetPerimetr()
        {
            throw new NotImplementedException();
        }
        public override string ToString() => $"Center = {{{Center}}}, Radius = {Radius}";
    }
}
