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

namespace NeoStackTestApp
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private FunctionModel _selectedFunction;
        private ObservableCollection<double> _cList;
        private ObservableCollection<FunctionModel> _functionsList;


        public ObservableCollection<FunctionModel> FunctionsList
        {
            get
            { 
                return _functionsList; 
            }
            set
            {
                _functionsList = value;
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
                OnPropertyChanged("CList");
            }
        }

        public FunctionModel SelectedFunction
        {
            get { return _selectedFunction; }
            set
            {
                value.F = Calculator.CalculateFunction(value);
                Debug.WriteLine("C = " + value.C);
                _selectedFunction = value;
                updateCList();
                OnPropertyChanged("SelectedFunction");
            }
        }

        public ApplicationViewModel()
        {
            InitFunctionsList();
            _selectedFunction = FunctionsList[0];

            updateCList();


        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
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

        private void updateCList()
        {
            CList = Calculator.GetCList(5, _selectedFunction.Degree);
        }

    }
}
