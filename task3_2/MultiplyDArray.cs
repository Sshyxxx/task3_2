using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2
{
    sealed class MultiplyDArray : BaseArray
    {
        private int[,] _array;
        private int _row;
        private int _col;

        public MultiplyDArray(int row, int collumn, bool isUser = false)
        {
            _array = new int[row, collumn];
            _row = row;
            _col = collumn;
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
            int count = 0;
            double sum = 0;
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    sum += _array[i, j];
                    count++;
                }
            }

            return sum / count;
        }


        public override void GetIntValues()
        {
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    Console.WriteLine($"элемент № {j}");

                    _array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void GetRandomValues()
        {

            Random random = new Random();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _col; j++)
                {
                    _array[i, j] = random.Next(0, 255);
                }
            }
        }

        public override void PrintArray()
        {
            int rows = _array.GetLength(0);
            int columns = _array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(_array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }

}
