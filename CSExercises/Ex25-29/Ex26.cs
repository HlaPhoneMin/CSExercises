using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("NO   " + " INVERSE "  + " SQUARE ROOT "  +"\t" + " SQUARE ");
            
            for (double k = 1; k < 11; k++)
            {
                double Inverse = 1/k, SquareRoot = Math.Sqrt(k), Square = Math.Pow(k,2);
                Console.WriteLine("{0:###.0##}\t {1:##0.###} \t {2:###.0##} \t\t {3:###.0##}", k,Inverse,SquareRoot,Square);
            }

            Console.ReadLine();
        }
    }
}
