using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            OneDArray one = new OneDArray(4);
            BaseArray two = new OneDArray(3);

            MultiplyDArray three = new MultiplyDArray(4, 4);
            BaseArray four = new MultiplyDArray(4, 5);

            SteppedArray five = new SteppedArray(4);
            BaseArray six = new SteppedArray(5);
  
            BaseArray[] baseArrays = new BaseArray[6]
            {
                one, two, three, four, five, six
            };

            foreach(BaseArray item in baseArrays)
            {
                Console.WriteLine($"Среднее значение {item.GetType()} массива {item.AverageValue()}\n");
                Console.WriteLine($"Элементы массива {item.GetType()}\n");
                item.PrintArray();
            }
            Console.ReadLine();

        }
    }

    
}
