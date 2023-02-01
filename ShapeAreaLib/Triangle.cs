using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Triangle : Shape
    {
        public double S1;
        public double S2;
        public double S3;

        public Triangle(double s1, double s2, double s3)
        {
            S1 = s1;
            S2 = s2;
            S3 = s3;
        }

        public override double GetArea() 
        {
            double P = (S1 + S2 + S3) / 2;
            return Math.Sqrt(P * (P - S1) * (P - S2) * (P - S3));
        }

        public bool IsRightTriangle()
        {
            bool Result = false;
            double S1SQ = Math.Pow(S1, 2);
            double S2SQ = Math.Pow(S2, 2);
            double S3SQ = Math.Pow(S3, 2);
            if (S1SQ == S2SQ + S3SQ || S2SQ == S1SQ + S3SQ || S3SQ == S1SQ + S2SQ)
            {
                Result = true;
            }
            return Result;
        }
    }
}
