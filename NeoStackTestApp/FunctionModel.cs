using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public class FunctionModel
    {
        public FunctionModel(string functionName, string function, int degree)
        {
            FunctionName = functionName;
            Function = function;
            Degree = degree;
        }

        public string FunctionName { get;}
        public string Function { get;}
        public int Degree { get; }

        public string getFunctionDescription()
        {
            string functionDescription = $"Выбранная функция:\n{FunctionName} {Function}";
            return functionDescription;
        }
    }
}
