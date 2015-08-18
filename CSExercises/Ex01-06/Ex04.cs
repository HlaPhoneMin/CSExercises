using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double UserInput, SquareRoot;
            
            Console.Write("Enter a number : ");
            UserInput = double.Parse(Console.ReadLine());
            
            SquareRoot = Math.Sqrt(UserInput);

            Console.WriteLine("Square Root of your entered number : " + SquareRoot);
            
            Console.ReadLine();
        
        }
    }
}
