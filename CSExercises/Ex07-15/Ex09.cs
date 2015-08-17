using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double UserInput, Output;
            Console.Write("Enter the number : ");
            UserInput = Convert.ToDouble(Console.ReadLine());
            Output = 2 * (UserInput * UserInput) - 4 * (UserInput) + 3;
            Console.WriteLine("The Output of y in the equation y is {0}", Output);
            Console.ReadLine();
        }
    }
}
