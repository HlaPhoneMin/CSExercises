using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        { 

            Console.WriteLine("The perfect numbers between 1 to 1000");
            
            for (int j = 1; j <1000; j++)
            {
                int Number = 0;
            
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        Number += i;
                    }
                }
                
                if (Number == j)
                {
                    Console.WriteLine(j);
                }
            
            }
            
            Console.ReadLine();
        }
    }
}
