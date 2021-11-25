using NeoStackTestApp.Other;

namespace NeoStackTestApp.Models
{
    /// <summary>
    /// Модель аргументов функции
    /// </summary>
    public class FunctionArgsModel : BasePropertyChangedHandler<FunctionArgsModel>
    {
        #region variables
        private double _f, _x, _y;
        private bool _enableDebugLogging = false;
        private string _details;
        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор класса с полным набором параметров
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="selectedFunctionModel"></param>
        public FunctionArgsModel(double x, double y, FunctionModel selectedFunctionModel)
        {
            X = x;
            Y = y;
            F = Calculator.CalculateFunction(selectedFunctionModel, this);
            updateDetails();

        }
        /// <summary>
        /// Конструктор класса с частичным набором параметров
        /// </summary>
        public FunctionArgsModel()
        {
            X = 0;
            Y = 0;
            F = Calculator.CalculateFunction(StaticData.SelectedItem, this);
            updateDetails();

        }
        #endregion

        /// <summary>
        /// Геттеры и сеттеры для свойств класса. В каждом сеттере вызывается метод обработки события смены свойства
        /// </summary>
        #region Properties
        public double F
        {
            get { return _f; }
            set
            {
                _f = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                if(StaticData.SelectedItem != null)
                {
                    F = Calculator.CalculateFunction(StaticData.SelectedItem, this);
                    updateDetails();
                }               
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                if (StaticData.SelectedItem != null)
                {
                    F = Calculator.CalculateFunction(StaticData.SelectedItem, this);
                    updateDetails();
                }
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }

        public string Details
        {
            get { return _details; }
            set 
            { 
                _details = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging); 
            }
        }
        #endregion

        private void updateDetails()
        {
            if(StaticData.SelectedItem != null)
            {
                Details = $"Аргументы функции: c = {StaticData.SelectedItem.C}, a = {StaticData.SelectedItem.A}, b = {StaticData.SelectedItem.B}";
            }
            else
            {
                Details = $"Аргументы функции: c = NAN, a = NAN, b = NAN";
            }
            
        }
    }
}
