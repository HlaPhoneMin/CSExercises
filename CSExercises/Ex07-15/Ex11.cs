using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double X1, Y1, X2, Y2, Distance;
            
            Console.Write("Enter the coordinate for x1 : ");
            X1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the coordinate for y1 : ");
            Y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the coordinate for x2 : ");
            X2 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the coordinate for y2 : ");
            Y2 = Convert.ToDouble(Console.ReadLine());
            
            Distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            
            Console.WriteLine("The Distance between the two points is {0}", Distance);
            
            Console.ReadLine(); 
        
        }
    }
}
