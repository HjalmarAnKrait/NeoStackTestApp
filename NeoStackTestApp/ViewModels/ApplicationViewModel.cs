using System.Collections.ObjectModel;
using NeoStackTestApp.Other;

namespace NeoStackTestApp
{
    /// <summary>
    /// ViewModel для MainWindow.xaml
    /// Реализует интерфейс INotifyPropertyChanged
    /// </summary>
    public class ApplicationViewModel : BasePropertyChangedHandler<ApplicationViewModel>
    {
        #region variables

        private FunctionModel _selectedFunction;

        private ObservableCollection<double> _cList;
        private ObservableCollection<FunctionModel> _functionsList;
        private bool _enableDebugLogging = true;
        #endregion

        /// <summary>
        /// Геттеры и сеттеры для свойств класса. На каждый метод Set прописан метод OnPropertyChanged
        /// </summary>
        #region properties
        public ObservableCollection<FunctionModel> FunctionsList
        {
            get{ return _functionsList; }
            set
            {
                _functionsList = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }
        
        public ObservableCollection<double> CList
        {
            get{ return _cList; }
            set
            {
                _cList = value;
                OnPropertyChanged(enableDebugLogging: _enableDebugLogging);
            }
        }

        public FunctionModel SelectedFunction
        {
            get
            { return _selectedFunction; }
            set
            {
                StaticData.SelectedItem = value;
                _selectedFunction = value;
                UpdateCList();

                OnPropertyChanged(value.C, enableDebug: _enableDebugLogging);   
            }
        }
        #endregion

        /// <summary>
        /// Конструктор класса ViewModel
        /// </summary>
        public ApplicationViewModel()
        {
            InitFunctionsList();
            SelectedFunction = FunctionsList[0];
            UpdateCList();
        }

        #region Methods
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
            CList = Calculator.GetCList(FunctionsList.Count, _selectedFunction.Degree);
        }
        #endregion

       

    }
}
