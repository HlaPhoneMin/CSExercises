using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        { 
            int RandomNumber, GuessNumber, Count = 1;

            Random Rd = new Random();
            RandomNumber = Rd.Next(0,9);

            Console.WriteLine(RandomNumber);

            Console.Write("Think of a Number : ");
            GuessNumber = Convert.ToInt32(Console.ReadLine());
            
            while (RandomNumber != GuessNumber)
            {   
                Count++;
                Console.WriteLine("Try Again");
                Console.Write("Think of a Number : ");
                GuessNumber = Convert.ToInt32(Console.ReadLine());
            }
            
            if (Count == 1)
            {
                Console.WriteLine("Congratulation! You have found the number in the first time.");
            }
            else
            {
                Console.WriteLine("Congratulation! You have found the number in the {0} times.", Count);
            }

            if (Count > 0 && Count < 3)
            {
                Console.WriteLine("You are a wizard");
            }
            else if (Count > 2 && Count < 6)
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy");
            }
            Console.ReadLine();
        }
    }
}
