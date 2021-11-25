using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NeoStackTestApp.Other
{
    /// <summary>
    /// Базовый класс для объектов, где требуется имплементация INotifyPropertyChanged
    /// </summary>
    /// <typeparam name="T">Обобщённый параметр, необходимый для вывода в дебаг названия класса, с которого метод был вызыван</typeparam>
    public class BasePropertyChangedHandler<T>: INotifyPropertyChanged
    {

        /// <summary>
        /// Событие смены свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Метод, вызываемый при смене значения у свойства.
        /// </summary>
        /// <param name="prop">Название свойства, которое изменилось</param>
        /// <param name="enableDebugLogging">Параметр для включения вывода сообщения в консоль</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "", bool enableDebugLogging = true)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            if(enableDebugLogging)
            {
                Debug.WriteLine($"{DateTime.Now.ToString("h:mm:ss tt")} {typeof(T).Name} PropertyChanged: {prop}.");
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">Свойство, которое изменилось</param>
        /// <param name="prop">Название свойства, которое изменилось</param>
        /// <param name="enableDebug">Параметр для включения вывода сообщения в консоль</param>
        public void OnPropertyChanged(object value, [CallerMemberName] string prop = "", bool enableDebug = true)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            if (enableDebug)
            {
                Debug.WriteLine($"{DateTime.Now.ToString("h:mm:ss tt")} {typeof(T).Name} PropertyChanged: {prop}; Value: {value}");
            }
        }
    }
}
