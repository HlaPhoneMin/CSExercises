using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("The prime numbers between 1 to 1000");
           
            for(int j=2; j<1000; j++){
                int k = 0;
                
                for (int i = 1; i <= j; i++)
                {

                    if (j % i == 0)
                    {

                        k++;

                    }

                }

                if (k == 2)
                {

                    Console.WriteLine(j);

                }

            }

            Console.ReadLine();
        }
    }
}
