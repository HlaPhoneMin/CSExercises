using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        { 
            int UserInput, Number = 0;

            Console.Write("Enter a number : ");
            UserInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < UserInput; i++)
            {
                if (UserInput % i == 0)
                {
                    Number += i;
                }
            }
            if (Number == UserInput)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
            Console.ReadLine();
        }
    }
}
