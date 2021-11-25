using NeoStackTestApp.Models;
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

namespace NeoStackTestApp
{
    /// <summary>
    /// Модель функции, содержащая в себе необходимые данные для её расчёта
    /// </summary>
    public class FunctionModel : INotifyPropertyChanged
    {
        #region variables
        private string _functionName, _function;
        private double _degree;
        private double _a, _b, _c;
        private int _comboBoxSelectedIndex;
        private ObservableCollection<FunctionArgsModel> _functionArgsModelList;

        /// <summary>
        /// Строка, содержащая в себе название класса.
        /// </summary>
        public const string ClassName = "FunctionModel";
        #endregion


        #region constructors
        public FunctionModel(string functionName, string function, double degree, double a, double b, double c)
        {
            FunctionName = functionName;
            Function = function;
            Degree = degree;
            FunctionArgsModelList = new ObservableCollection<FunctionArgsModel>();
            A = a;
            B = b;
            C = c;
        }

        public FunctionModel(string functionName, string function, Double degree)
        {
            FunctionName = functionName;
            Function = function;
            Degree = degree;
            FunctionArgsModelList = new ObservableCollection<FunctionArgsModel>();
            A = 0;
            B = 0;
            C = 0;
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
                OnPropertyChanged();
            }
        }
        public int ComboBoxSelectedIndex
        {
            get { return _comboBoxSelectedIndex; }
            set
            {
               _comboBoxSelectedIndex = value;
                OnPropertyChanged();
            }
        }
        public string Function
        {
            get { return _function; }
            set
            {
                _function = value;
                OnPropertyChanged();
            }
        }
        public double Degree
        {
            get { return _degree; }
            set
            {
                _degree = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<FunctionArgsModel> FunctionArgsModelList
        {
            get { return _functionArgsModelList;}
            set
            {
                _functionArgsModelList = value;
                OnPropertyChanged();
            }
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                StaticData.SelectedItem = this;
                OnPropertyChanged();
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
                StaticData.SelectedItem = this;
                OnPropertyChanged();
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                _c = value;
                StaticData.SelectedItem = this;
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
