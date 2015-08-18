using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double UserInput, Square;
            
            Console.Write("Enter a number : ");
            UserInput = double.Parse(Console.ReadLine());
            
            Square = Math.Pow(UserInput, 2);
            
            Console.WriteLine("Square of your entered number : " + Square);
            
            Console.ReadLine(); 
        }
    }
}
