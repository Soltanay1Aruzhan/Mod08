using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            GrocerySupermarket zakup = new GrocerySupermarket();
            int[] korzina = { zakup.Bread, zakup.Milk, zakup.eggs };
            zakup.Date = DateTime.Now;
            Zakup(korzina, zakup);
            
        }
        public static void Zakup(int[] korzina, GrocerySupermarket t)
        {
            double sum = 0;
            if (t.Date.TimeOfDay >= t.startTime && t.Date.TimeOfDay <= t.endTime)
            {
                for (int i = 0; i < korzina.Length; i++)
                {
                    sum += korzina[i] - korzina[i] * 0.15;
                }
                Console.WriteLine($"Сумма товаров: {sum} тенге");
            }
            else
            {
                for (int i = 0; i < korzina.Length; i++)
                {
                    sum += korzina[i];
                }
                Console.WriteLine($"Сумма товаров: {sum} тенге");
            }
        }
    }
}
