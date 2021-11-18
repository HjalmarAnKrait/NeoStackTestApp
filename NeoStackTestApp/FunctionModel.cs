using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public class FunctionModel : INotifyPropertyChanged
    {
        private string _functionName, _function;
        private double _degree;
        private double _a, _b, _c, _f, _x, _y;
        private int _selectedPosition;

        public FunctionModel(string functionName, string function, int degree)
        {
            FunctionName = functionName;
            Function = function;
            Degree = degree;
            SelectedPosition = 0;
            A = 0;
            B = 0;
            C = 0;
            F = 0;
            X = 0;
            Y = 0;
        }

        public FunctionModel(string functionName, string function, double degree, double a, double b, double c, double f, double x, double y)
        {
            FunctionName = functionName;
            Function = function;
            SelectedPosition = 0;
            Degree = degree;
            A = a;
            B = b;
            C = c;
            F = f;
            X = x;
            Y = y;
        }

        //Getters and setters
        #region
        public string FunctionName
        {
            get { return _functionName; }
            set
            {
                _functionName = value;
                OnPropertyChanged("FunctionName");
            }
        }
        public string Function
        {
            get { return _function; }
            set
            {
                _function = value;
                OnPropertyChanged("Function");
            }
        }
        public double Degree
        {
            get { return _degree; }
            set
            {
                _degree = value;
                OnPropertyChanged("Degree");
            }
        }

        public int SelectedPosition
        {
            get { return _selectedPosition; }
            set
            {
                _selectedPosition = value;
                OnPropertyChanged("SelectedPosition");
            }
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged("A");
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                OnPropertyChanged("B");
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                OnPropertyChanged("C");
            }
        }
        public double F
        {
            get { return _f; }
            set
            {
                _f = value;
                OnPropertyChanged("F");
            }
        }
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged("X");
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged("Y");
            }
        }

#endregion


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
