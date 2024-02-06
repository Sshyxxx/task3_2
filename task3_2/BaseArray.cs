using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3_4;

namespace task3_2
{
    public abstract class BaseArray: IArray, IPrinter
    {
        /// <summary>
        /// Заполнение массива целыми числами
        /// </summary>     
        public abstract void GetIntValues();


        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>     
        public abstract void GetRandomValues();

        /// <summary>
        /// Выводит на экран массив
        /// </summary>    
        public abstract void Print();

  
        /// <summary>
        /// Считает среднее значение массива
        /// </summary>
        /// <returns>Дробное число, сумма, поделенная на количество элементов</returns>
        public abstract double AverageValue();

    }

}
