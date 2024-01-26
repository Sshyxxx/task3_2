using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2
{
    public abstract class BaseArray
    {
        //
        // Сводка:
        //     Заполнение массива целыми числами
        public abstract void GetIntValues();


        //
        // Сводка:
        //     Заполнение массива случайными числами
        public abstract void GetRandomValues();

        //
        // Сводка:
        //     Выводит на экран массив
        public abstract void PrintArray();

        //
        // Сводка:
        //     Считает среднее значение массива
        //
        // Возврат:
        //     Дробное число, сумма, поделенная на количество элементов
        public abstract double AverageValue();
    }

}
