using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        { 
            int UserInput, k=0;

            Console.Write("Enter a number : ");
            UserInput=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= UserInput; i++)

            {

                if (UserInput % i == 0)

                {

                    k++;

                }

            }

            if (k == 2)

            {

                Console.WriteLine("Your Number is a Prime Number");

            }

            else

            {

                Console.WriteLine("Your number is not a Prime Number");

            }

            Console.ReadLine();

        }
    }
}
