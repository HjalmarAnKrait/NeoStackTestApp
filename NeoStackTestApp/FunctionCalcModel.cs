using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public class FunctionCalcModel
    {
        public FunctionCalcModel(double a, double b, double c, double f, double x, double y, double degree)
        {
            A = a;
            B = b;
            C = c;
            F = f;
            X = x;
            Y = y;
            Degree = degree;
        }

        public FunctionCalcModel()
        {
            A = 0;
            B = 0;
            C = 0;
            F = 0;
            X = 0;
            Y = 0;
            Degree = 0;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double F { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Degree { get; set; }

        
    }
}
