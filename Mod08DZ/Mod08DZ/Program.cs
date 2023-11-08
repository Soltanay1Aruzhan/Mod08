using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod08DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Үйдің аумағын енгізіңіз (в м^2): ");
            double squareArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Тұрғындардың санын енгізіңіз: ");
            int numberOfResidents = Convert.ToInt32(Console.ReadLine());

            Console.Write("Маусымды енгізіңіз (1 - Көктем, 2 - Жаз, 3 - Күз немесе 4 - Қыс): ");
            int season = Convert.ToInt32(Console.ReadLine());

            Console.Write("Льготтарды еңгізіңіз (1 - Еңбек ардагері, 2 - Соғыс ардагері, 3 - льготтар жоқ): ");
            int discountType = Convert.ToInt32(Console.ReadLine());

            // Тарифтар
            double heatingRate = 10;  // Тариф жылытуға (на 1 м^2)
            double waterRate = 5;     // Тариф суға (на 1 человека)
            double gasRate = 3;       // Тариф газға (на 1 человека)
            double repairRate = 7;    // Тариф ремонтқа (на 1 м^2)

            // Алымдарды есептеу
            double heatingPayment;
            if (season >= 3)
            {
                heatingPayment = squareArea * heatingRate + (squareArea * heatingRate)*0.5;
            }
            else 
            {
                heatingPayment = squareArea * heatingRate;
            }
            double waterPayment = numberOfResidents * waterRate;
            double gasPayment = numberOfResidents * gasRate;
            double repairPayment = squareArea * repairRate;

            // Льготтарды есептеу
            double discount = 0;
            if (discountType == 1) // Еңбек ардагері - 30% жеңілдік
            {
                discount = 0.3;
            }
            else if (discountType == 2) // Соғыс ардагері - 50% жеңілдік
            {
                discount = 0.5;
            }

            // Жалпы есептеу
            double totalPayment = heatingPayment + waterPayment + gasPayment + repairPayment;
            totalPayment = totalPayment - (totalPayment * discount);
            Console.Clear();
            // Кестені шығару
            Console.WriteLine("Төлем түрі\t" + "Есептелінді\t" + "Льготная жеңілдік\t" + "жалпы сома");
            Console.WriteLine("Жылыту\t" + heatingPayment + "\t\t" + discount + "\t\t" + (heatingPayment - heatingPayment*discount));
            Console.WriteLine("Су\t\t" + waterPayment + "\t\t" + discount + "\t\t" + (waterPayment-waterPayment*discount));
            Console.WriteLine("Газ\t\t" + gasPayment + "\t\t" + discount + "\t\t" + (gasPayment-gasPayment*discount));
            Console.WriteLine("Ремонт\t\t" + repairPayment + "\t\t" + discount + "\t\t" + (repairPayment - repairPayment*discount));
            Console.WriteLine("Жалпы сома\t\t" + + totalPayment);

        }
    }
}
