using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Double UserInput, SquareRoot, ThreeDecimal;
            Console.Write("Enter a number : ");
            UserInput = double.Parse(Console.ReadLine());
            SquareRoot = Math.Sqrt(UserInput);
            ThreeDecimal = SquareRoot;
            Console.WriteLine("Square Root rounded to 3 decimal places  of your entered number {0:###.000} ", ThreeDecimal);
            Console.ReadLine();
        }
    }
}
