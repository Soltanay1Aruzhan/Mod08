using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08prac
{
    public class RangeOfArray
    {
        private int lowerBound;
        private int upperBound;
        private int[] array;

        public RangeOfArray(int lower, int upper)
        {
            lowerBound = lower;
            upperBound = upper;
            array = new int[upper - lower + 1];
        }

        private bool IsInRange(int index)
        {
            return index >= lowerBound && index <= upperBound;
        }

        public int this[int index]
        {
            get
            {
                if (IsInRange(index))
                {
                    return array[index - lowerBound];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс ауқымнан тыс.");
                }
            }
            set
            {
                if (IsInRange(index))
                {
                    array[index - lowerBound] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс ауқымнан тыс.");
                }
            }
        }
    }
}
