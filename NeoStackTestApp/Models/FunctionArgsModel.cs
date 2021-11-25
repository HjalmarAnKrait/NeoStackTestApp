using NeoStackTestApp.Other;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp.Models
{
    /// <summary>
    /// Модель аргументов функции
    /// </summary>
    public class FunctionArgsModel : INotifyPropertyChanged
    {
        #region variables
        private double _f, _x, _y;
        /// <summary>
        /// Имя класса
        /// </summary>
        public const string ClassName = "FunctionArgsModel";
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
            
        }
        /// <summary>
        /// Конструктор класса с частичным набором параметров
        /// </summary>
        public FunctionArgsModel()
        {
            X = 0;
            Y = 0;
            F = Calculator.CalculateFunction(StaticData.SelectedItem, this);

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
                OnPropertyChanged();
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
                }               
                OnPropertyChanged();
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
                }
                OnPropertyChanged();
            }
        }
        #endregion


        #region Events
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
        #endregion
    }
}
