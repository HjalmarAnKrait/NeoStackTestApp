using NeoStackTestApp.Models;
using NeoStackTestApp.Other;
using System;
using System.Collections.ObjectModel;

namespace NeoStackTestApp
{
    /// <summary>
    /// Модель функции, содержащая в себе необходимые данные для её расчёта
    /// </summary>
    public class FunctionModel : BasePropertyChangedHandler<FunctionModel>
    {
        #region variables
        private string _functionName, _function;
        private double _degree;
        private double _a, _b, _c;
        private ObservableCollection<FunctionArgsModel> _functionArgsModelList;
        private bool _enableDebugLogging = true;
        #endregion


        #region constructors
        /// <summary>
        /// Конструктор класса с полным набором параметров
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="function"></param>
        /// <param name="degree"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public FunctionModel(string functionName, string function, double degree, double a, double b, double c)
        {
            FunctionName = functionName;
            Function = function;
            Degree = degree;
            FunctionArgsModelList = new ObservableCollection<FunctionArgsModel>();
            A = a;
            B = b;
            C = Calculator.CalcC(degree, 1.0);
        }

        /// <summary>
        /// Конструктор класса с частичным набором параметров
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="function"></param>
        /// <param name="degree"></param>
        public FunctionModel(string functionName, string function, Double degree)
        {
            FunctionName = functionName;
            Function = function;

            if (degree <= 0)
            {
                degree = 1;
            }

            Degree = degree;

            FunctionArgsModelList = new ObservableCollection<FunctionArgsModel>();
            A = 0;
            B = 0;
            C = Calculator.CalcC(degree, 1.0);
        }

        /// <summary>
        /// Конструктор класса для тестов
        /// </summary>
        /// <param name="degree"></param>
        public FunctionModel(double degree, double c,double a, double b)
        {
            FunctionName = "NAN";
            Function = "NAN";

            if(degree <= 0)
            {
                degree = 1;
            }

            Degree = degree;
            FunctionArgsModelList = new ObservableCollection<FunctionArgsModel>();
            A = a;
            B = b;
            C = Calculator.CalcC(degree, c);
        }


        #endregion

        /// <summary>
        ///  Геттеры и сеттеры для свойств класса. В каждом сеттере вызывается метод обработки события смены свойства
        /// </summary>
        #region Properties
        public string FunctionName
        {
            get { return _functionName; }
            set
            {
                _functionName = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public string Function
        {
            get { return _function; }
            set
            {
                _function = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public double Degree
        {
            get { return _degree; }
            set
            {
                _degree = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }

        public ObservableCollection<FunctionArgsModel> FunctionArgsModelList
        {
            get { return _functionArgsModelList;}
            set
            {
                _functionArgsModelList = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                StaticData.SelectedItem = this;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                StaticData.SelectedItem = this;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                StaticData.SelectedItem = this;
                OnPropertyChanged(value, enableDebug: _enableDebugLogging);
            }
        }
        #endregion

    }
}
