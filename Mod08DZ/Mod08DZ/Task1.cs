using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08DZ
{
    public class Task1
    {
        private double[] array;

        public Task1(int size)
        {
            array = new double[size];
        }

        
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс ауқымнан тыс.");
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value * value; 
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс ауқымнан тыс.");
                }
            }
        }
    }
}
