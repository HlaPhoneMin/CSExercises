using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{ 
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int LuckyNumber = 88, UserInput;

            do
            {
            
                Console.Write("Input a number : ");
                UserInput = Convert.ToInt32(Console.ReadLine());
            
            } while (UserInput != LuckyNumber);
            
            Console.WriteLine("Lucky you....");
            
            Console.ReadLine();
         
        }
    }
}
