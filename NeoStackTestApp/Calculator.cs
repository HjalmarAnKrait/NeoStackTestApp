﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStackTestApp
{
    /// <summary>
    /// Класс для расчётов.
    /// </summary>
    public static class Calculator
    {

        /// <summary>
        /// Статический Метод для подсчёта функции
        /// </summary>
        /// <param name="degree">Степень числа, для определение множителя коэффициента С</param>
        /// <param name="functionModel">Модель функции, содержащая в себе необходимые для расчёта данные</param>
        /// <returns>Результат подсчёта</returns>
        public static double CalculateFunction(double degree, FunctionModel functionModel)
        {
            if (degree == 0)
                degree = 1;

            double result =
                functionModel.A * Math.Pow(functionModel.X, degree) +
                functionModel.B * Math.Pow(functionModel.Y, degree - 1.0) +
                functionModel.C;

            return result;
        }

        /// <summary>
        /// Перегрузка статического метода для подсчёта функции
        /// </summary>
        /// <param name="functionModel">Модель функции, содержащая в себе необходимые для расчёта данные</param>
        /// <returns>Результат подсчёта</returns>
        public static double CalculateFunction(FunctionModel functionModel)
        {
            if (functionModel.Degree == 0)
                functionModel.Degree = 1;

            double result =
                functionModel.A * Math.Pow(functionModel.X, functionModel.Degree) +
                functionModel.B * Math.Pow(functionModel.Y, functionModel.Degree - 1.0) +
                functionModel.C;

            return result;
        }

        /// <summary>
        /// Метод для расчёта коэффициента С с учётом его множителя для выбранной функции
        /// </summary>
        /// <param name="degree">Степень числа, для определение множителя коэффициента С</param>
        /// <param name="с">Коэффициент С для его расчёта и дальнейшего возврата функцией</param>
        /// <returns>Коэффициент С, расчитанный с учётом его множителя для выбранной функции</returns>
        public static double CalcC(double degree, double c)
        {
            if (degree == 0)
                degree = 1;

            double result = Math.Pow(10, degree - 1.0) * c;
            return result;
        }

        /// <summary>
        /// Метод для расчёта списка коэффициентов С с учётом выбранной функции
        /// </summary>
        /// <param name="degree">Степень числа, для определение множителя коэффициента С</param>
        /// <param name="size">Размер списка для вывода</param>
        /// <returns>Список типа double</returns>
        public static ObservableCollection<double> GetCList(int size, double degree)
        {
            ObservableCollection<double> result = new ObservableCollection<double>();

            for (int i = 1; i <= size; i++)
            {
                result.Add(CalcC(degree, i));
            }

            return result;
        }

       
   

        
    }
}
