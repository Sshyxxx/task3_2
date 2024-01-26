using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2
{
    sealed class SteppedArray : BaseArray
    {
        private int[][] _array;
        private int _size;

        public SteppedArray(int size, bool isUser = false)
        {
            _size = size;
            _array = new int[_size][];

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                GetIntValues();
            }
        }

        public override double AverageValue()
        {
            double sum = 0;
            double count = 0;
            foreach (int[] item in _array)
            {
                sum += item.Sum();
                count += item.Length;
            }
            return sum / count;
        }

        public override void GetIntValues()
        {

            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"Сколько элементов в ступене массива？");
                int collumn = int.Parse(Console.ReadLine());
                _array[i] = new int[collumn];

                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine($"элемент № {i}{j}");
                    _array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void GetRandomValues()
        {
            Random random = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                int col = random.Next(3, 10);
                _array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    _array[i][j] = random.Next(0, 10);
                }
            }
        }

        public override void PrintArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
