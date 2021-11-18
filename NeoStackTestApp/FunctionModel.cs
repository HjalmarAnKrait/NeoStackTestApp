using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    class FunctionModel
    {
        public string FunctionName { get;}
        public string Function { get;}
        public int CMultiplier { get;}
        public int Degree { get; }

        //private int 

        public int getMultipliedC(int c)
        {
            return c * CMultiplier;
        }

        public string getFunctionDescription()
        {
            string functionDescription = $"Выбранная функция:\n{FunctionName} {Function}";
            return functionDescription;
        }
    }
}
