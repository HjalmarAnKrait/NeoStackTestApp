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
    /// <summary>
    /// Модель функции, содержащая в себе необходимые данные для её расчёта
    /// </summary>
    public class FunctionModel : INotifyPropertyChanged
    {
        private string _functionName, _function;
        private double _degree;
        private double _a, _b, _c, _f, _x, _y;
        private int _selectedPosition;

        /// <summary>
        /// Строка, содержащая в себе название класса.
        /// </summary>
        public const string ClassName = "FunctionModel";

        /// <summary>
        /// Конструктор для FunctionalModel с частичным набором параметров
        /// </summary>
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

        /// <summary>
        /// Конструктор для FunctionalModel с полным набором параметров
        /// </summary>
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

        /// <summary>
        /// Геттеры и сеттеры для свойств класса. На каждый метод Set прописан метод OnPropertyChanged
        /// </summary>
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
                Debug.WriteLine("before conver value " + value);
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

        /// <summary>
        /// Событие смены свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод, вызываемый при смене значения у свойства.
        /// </summary>
        /// <param name="prop">Название свойства, которое изменилось</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            Debug.WriteLine($" {DateTime.Now.ToString("h:mm:ss tt")}. {ClassName} PropertyChanged name - {prop}.");
        }
    }
}
