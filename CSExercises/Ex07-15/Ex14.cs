using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double ASide, BSide, CSide, S, Area;
            Console.WriteLine("Please Enter value for Side of A ");
            ASide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the value for Side of B ");
            BSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the value for Side of C");
            CSide = Convert.ToDouble(Console.ReadLine());
            S = (ASide + BSide + CSide) / 2;
            Area = Math.Sqrt(S * (S - ASide) * (S - BSide) * (S - CSide));
            Console.WriteLine("The Area of the triangle is {0}", Area);
            Console.ReadLine();
        }
    }
}