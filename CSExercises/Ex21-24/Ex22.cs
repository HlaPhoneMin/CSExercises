using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            double A, B, AIntoB, HCF, LCM;

            Console.Write("Enter A : ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter B : ");
            B = Convert.ToDouble(Console.ReadLine());

            AIntoB = A * B;

            while (A != B)
            {
                if (A < B)
                {
                    B = B - A;
                }
                else
                {
                    A = A - B;
                }
            }

            HCF = A;

            LCM = AIntoB / HCF;

            Console.WriteLine("HCF : {0}", HCF);

            Console.WriteLine("LCM : {0}", LCM);

            Console.ReadLine();
        }
    }
}
