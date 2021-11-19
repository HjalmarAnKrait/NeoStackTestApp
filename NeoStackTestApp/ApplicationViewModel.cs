using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;

namespace NeoStackTestApp
{
    /// <summary>
    /// ViewModel для MainWindow.xaml
    /// </summary>
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private FunctionModel _selectedFunction;
        private ObservableCollection<double> _cList;
        private ObservableCollection<FunctionModel> _functionsList;

        /// <summary>
        /// Геттеры и сеттеры для свойств класса. На каждый метод Set прописан метод OnPropertyChanged
        /// </summary>
        #region
        public ObservableCollection<FunctionModel> FunctionsList
        {
            get
            { 
                return _functionsList;
            }
            set
            {
                _functionsList = value;
                Debug.WriteLine("FunctionsList updated");
                OnPropertyChanged("FunctionsList");
            }
        }
        
        public ObservableCollection<double> CList
        {
            get
            {
                return _cList;
            }
            set
            {
                _cList = value;
                Debug.WriteLine("CList updated");
                OnPropertyChanged("CList");
            }
        }

        
        public FunctionModel SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                value.F = Calculator.CalculateFunction(value);
                _selectedFunction = value;
                Debug.WriteLine("SelectedFunctionUpdated");
                UpdateCList();
                OnPropertyChanged("SelectedFunction");
            }
        }

        #endregion

        /// <summary>
        /// Конструктор класса ViewModel
        /// </summary>
        public ApplicationViewModel()
        {
            InitFunctionsList();
            _selectedFunction = FunctionsList[0];
            UpdateCList();


        }

        private void InitFunctionsList()
        {
            FunctionsList = new ObservableCollection<FunctionModel>();

            FunctionsList.Add(new FunctionModel("Линейная", "f(x, y) = ax + by^0 + c", 1));
            FunctionsList.Add(new FunctionModel("Квадратичная", "f(x, y) = ax^2 + by^1 + c", 2));
            FunctionsList.Add(new FunctionModel("Кубическая", "f(x, y) = ax^3 + by^2 + c", 3));
            FunctionsList.Add(new FunctionModel("4-ой степени", "f(x, y) = ax^4 + by^3 + c", 4));
            FunctionsList.Add(new FunctionModel("5-ой степени", "f(x, y) = ax^5 + by^4 + c", 5));
        }
     
        private void UpdateCList()
        {
            CList = Calculator.GetCList(5, _selectedFunction.Degree);
        }


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
        }
        

    }
}
