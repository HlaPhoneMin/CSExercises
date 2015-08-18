using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    { 
        public static void Main(string[] args)
        {
            double TvQuantity, DvdQuantity, Mp3Quantity, TvPrice, DvdPrice, Mp3Price, TvDiscount, DvdDiscount,TotalPrice;

            Console.Write("Enter quantity for TV : ");
            TvQuantity = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter quantity for DVD : ");
            DvdQuantity = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter quantity for MP3 : ");
            Mp3Quantity = Convert.ToDouble(Console.ReadLine());
            
            TvPrice = TvQuantity * 900;
            DvdPrice = DvdQuantity * 500;
            Mp3Price = Mp3Quantity * 700;
            
            if (TvPrice > 5000 && TvPrice < 10000)
            {
                TvDiscount = TvPrice * 10 / 100;
                TvPrice -= TvDiscount;
            }
            else if (TvPrice > 10000)
            {
                TvDiscount = TvPrice * 15 / 100;
                TvPrice -= TvDiscount;
            }
            
            if (DvdPrice > 5000 && DvdPrice < 10000)
            {
                DvdDiscount = DvdPrice * 10 / 100;
                DvdPrice -= DvdDiscount;
            }
            else if (DvdPrice > 10000)
            {
                DvdDiscount = DvdPrice * 15 / 100;
                DvdPrice -= DvdDiscount;
            }

            TotalPrice = TvPrice + DvdPrice + Mp3Price;
            
            Console.WriteLine("Total price for this order is ${0}", TotalPrice);
            
            Console.ReadLine();
        }
    }
}