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
            double TVQuantity, DVDQuantity, MP3Quantity, TVPrice, DVDPrice, MP3Price, TotalPrice;
            Console.Write("Enter quantity for TV : ");
            TVQuantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity for DVD : ");
            DVDQuantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity for MP3 : ");
            MP3Quantity = Convert.ToDouble(Console.ReadLine());
            TVPrice = TVQuantity * 900;
            DVDPrice = DVDQuantity * 500;
            MP3Price = MP3Quantity * 700;
            if (TVPrice > 5000 && TVPrice < 10000)
            {
                TVPrice *= 10 / 100;
            }
            else if (TVPrice > 10000)
            {
                TVPrice *= 15 / 100;
            }
            if (DVDPrice > 5000 && DVDPrice < 10000)
            {
                TVPrice *= 10 / 100;
            }
            else if (DVDPrice > 10000)
            {
                TVPrice *= 15 / 100;
            }
            TotalPrice = TVPrice + DVDPrice + MP3Price;
            Console.WriteLine("Total price for this order is ${0}", TotalPrice);
            Console.ReadLine();
        }
    }
}