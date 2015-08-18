using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double TotalFare, Distance;
             
            Console.Write("Enter the distance you want to travel : ");
            Distance = Convert.ToDouble(Console.ReadLine());
            
            TotalFare = 2.40 + Distance * 0.4;
            
            Console.WriteLine("The total fare is {0:####.00}", TotalFare);
            
            Console.ReadLine();
        
        }
    }
}
