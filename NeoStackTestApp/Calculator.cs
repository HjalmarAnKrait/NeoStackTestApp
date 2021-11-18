using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public static class Calculator
    {

        public static double CalculateFunction(double degree, FunctionCalcModel functionCalcModel)
        {
            if (degree == 0)
                degree = 1;

            double result =
                functionCalcModel.A * Math.Pow(functionCalcModel.X, degree) + 
                functionCalcModel.B * Math.Pow(functionCalcModel.Y, degree - 1.0) +
                CalcC(degree, functionCalcModel.C);

            return result;
        }

        public static double CalculateFunction(FunctionCalcModel functionCalcModel)
        {
            if (functionCalcModel.Degree == 0)
                functionCalcModel.Degree = 1;

            double result =
                functionCalcModel.A * Math.Pow(functionCalcModel.X, functionCalcModel.Degree) +
                functionCalcModel.B * Math.Pow(functionCalcModel.Y, functionCalcModel.Degree - 1.0) +
                CalcC(functionCalcModel.Degree, functionCalcModel.C);

            return result;
        }

        public static double CalcC(double degree, double c)
        {
            if (degree == 0)
                degree = 1;

            double result = Math.Pow(10, degree - 1.0) * c;

            return result;
        }

        public static List<double> GetCList(int size, double degree)
        {
            List<double> result = new List<double>();

            for (int i = 1; i <= size; i++)
            {
                result.Add(CalcC(degree, i));
            }

            return result;
        }

       
   

        
    }
}
