using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        { 
            int UserInput, FactorialDescending = 1, FactorialAscending = 1; 

            Console.Write("Enter a number : ");
            UserInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= UserInput; i++)
            {
                if (i == UserInput)
                {
                    Console.Write(i + "\n");
                }
                else
                {
                    Console.Write(i + "*");
                }
                FactorialAscending *= i;
            }

            Console.WriteLine("Factorial is {0} \n", FactorialAscending);
            
            for (int j = UserInput; j > 0; j--)
                {
                    if (j == 1)
                    {
                        Console.Write(j + "\n");
                    }
                    else
                    {
                        Console.Write(j + "*");
                    }
                    FactorialDescending *= j;
                }
            Console.WriteLine("Factorial is {0}", FactorialDescending);
            
            Console.ReadLine();
        }
    }
}
