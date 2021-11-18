using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public static class Calculator
    {

        public static double CalculateFunction(double degree, FunctionModel functionModel)
        {
            if (degree == 0)
                degree = 1;

            double result =
                functionModel.A * Math.Pow(functionModel.X, degree) +
                functionModel.B * Math.Pow(functionModel.Y, degree - 1.0) +
                functionModel.C;

            return result;
        }

        public static double CalculateFunction(FunctionModel functionModel)
        {
            if (functionModel.Degree == 0)
                functionModel.Degree = 1;

            double result =
                functionModel.A * Math.Pow(functionModel.X, functionModel.Degree) +
                functionModel.B * Math.Pow(functionModel.Y, functionModel.Degree - 1.0) +
                functionModel.C;

            return result;
        }

        public static double CalcC(double degree, double c)
        {
            if (degree == 0)
                degree = 1;

            double result = Math.Pow(10, degree - 1.0) * c;

            return result;
        }

        public static ObservableCollection<double> GetCList(int size, double degree)
        {
            ObservableCollection<double> result = new ObservableCollection<double>();

            for (int i = 1; i <= size; i++)
            {
                result.Add(CalcC(degree, i));
            }

            return result;
        }

       
   

        
    }
}
