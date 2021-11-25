using System;
using System.Diagnostics;

namespace NeoStackTestApp.Other
{
    /// <summary>
    /// Статический класс для хранения статических данных
    /// </summary>
    public static class StaticData
    {
        private static FunctionModel _selectedItem;

        /// <summary>
        /// Статическое свойство класса, хранящее в себе текущий выбранный элемент в списке функций
        /// </summary>
        public static FunctionModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
            }
        }
    }
}
