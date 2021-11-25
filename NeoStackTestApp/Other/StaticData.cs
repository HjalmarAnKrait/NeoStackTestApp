using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp.Other
{
    /// <summary>
    /// Статический класс для хранения статических данных
    /// </summary>
    public static class StaticData
    {
        private static FunctionModel _selectedItem;
        static public event EventHandler SelectedItemChanged;

        /// <summary>
        /// Статическое свойство класса, хранящее в себе текущий выбранный элемент в списке функций
        /// </summary>
        public static FunctionModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                Debug.WriteLine($"Selected a = {value.A}, b = {value.B}, c = {value.C}, selectedIndex = {value.ComboBoxSelectedIndex}");
                _selectedItem = value;
                SelectedItemChanged?.Invoke(null, EventArgs.Empty);
            }
        }
    }
}
