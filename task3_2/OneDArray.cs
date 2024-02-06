using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2
{
    sealed class OneDArray : BaseArray
    {
        private int[] _array;
        private int _size;

        public OneDArray(int size, bool isUser = false)
        {
            _size = size;
            _array = new int[_size];

            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                GetIntValues();
            }
        }

        public override void GetIntValues()
        {
            Console.WriteLine("введите " + _size + " элементов ");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"элемент № {i}");
                _array[i] = int.Parse(Console.ReadLine());
            }
        }

        public override double AverageValue()
        {
            int count = _array.Length;
            double sum = 0;

            for (int i = 0; count > i; i++)
            {
                sum += _array[i];
            }
            return sum / count;
        }

        public override void GetRandomValues()
        {
            Random random = new Random();
            for (int i = 0; i < _size; i++)
            {
                _array[i] = random.Next(0, 255);
            };
        }

        public override void Print()
        {
            foreach (int i in _array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }

}
