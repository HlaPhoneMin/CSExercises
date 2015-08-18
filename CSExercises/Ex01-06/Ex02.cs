using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            string UserInput; int Number, Square;
            
            Console.Write("Enter a number : ");
            UserInput = Console.ReadLine();
            
            Number = Convert.ToInt32(UserInput);
            
            Square = Number * Number;
            
            Console.WriteLine("Square of your entered number : " + Square);
            
            Console.ReadLine();
        
        }
    }
}
