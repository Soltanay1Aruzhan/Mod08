using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08prac
{
    public class GrocerySupermarket
    {
        public int Bread = 150;
        public int Milk = 400;
        public int Tomat = 1000;
        public int eggs = 600;
        public TimeSpan startTime = new TimeSpan(8, 0, 0); 
        public TimeSpan endTime = new TimeSpan(12, 0, 0);

        public DateTime Date {  get; set; }

        


    }
}
