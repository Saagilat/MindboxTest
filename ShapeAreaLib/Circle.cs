using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Circle : Shape
    {
        public Circle(double radius) 
        { 
            Radius = radius; 
        }
        public double Radius;
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
