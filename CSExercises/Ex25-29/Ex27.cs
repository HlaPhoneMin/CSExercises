using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        { 
            double y = 0;

            Console.WriteLine("X" + "\t" + "Y");
            
            for (int x = -5; x < 6; x++) { 

                y = 2 * (x * x) - 4 * x + 3;
                Console.WriteLine("{0:###.0} \t {1:###.0}",x,y);

                for (double j = y; j >= 1; j--)
                {
                    Console.Write("{0}", '*');
                    
                }

                Console.WriteLine();    
            }

           
            Console.ReadLine();
        }
    }
}
