using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    public class FunctionArgsModel: INotifyPropertyChanged
    {
        private double _f, _x, _y;
        private int _positionInList;
        private FunctionModel _functionModel;

        public FunctionArgsModel(FunctionModel functionModel, double f, double x, double y, int positionInList)
        {
            FunctionModel = functionModel;
            F = f;
            X = x;
            Y = y;
            PositionInList = positionInList;
        }

        public FunctionArgsModel(FunctionModel functionModel, int positionInList)
        {
            FunctionModel = functionModel;
            F = 0;
            X = 0;
            Y = 0;
            PositionInList = positionInList;
        }

        public int PositionInList
        {
            get { return _positionInList; }
            set
            {
                _positionInList = value;
                OnPropertyChanged("PositionInList");
            }
        }

        public FunctionArgsModel(FunctionModel functionModel)
        {
            FunctionModel = functionModel;
            F = 0;
            X = 0;
            Y = 0;
        }

        public FunctionModel FunctionModel
        {
            get { return _functionModel; }
            set
            {
                _functionModel = value;
                F = Calculator.CalculateFunction(value);
                OnPropertyChanged("FunctionModel");
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
                 F = Calculator.CalculateFunction(FunctionModel);
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
                F = Calculator.CalculateFunction(FunctionModel);
                OnPropertyChanged("Y");
            }
        }

        public const string ClassName = "FunctionArgsModel";

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            Debug.WriteLine($" {DateTime.Now.ToString("h:mm:ss tt")}. {ClassName} PropertyChanged name - {prop}.");
        }
    }
}
