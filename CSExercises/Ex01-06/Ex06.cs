using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        { 
            double UserInput; int SquareRoot;
            
            Console.Write("Enter a number : ");
            UserInput = double.Parse(Console.ReadLine());
            
            SquareRoot = (int)(Math.Sqrt(UserInput));

            Console.WriteLine("Square Root of your entered number {0} ", SquareRoot);
            
            Console.ReadLine();
        
        }
    }
}
