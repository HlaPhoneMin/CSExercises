using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int Mark;
            
            Console.Write("Enter your mark : ");
            Mark = Convert.ToInt32(Console.ReadLine());
            
            if (Mark < 100 && Mark >79)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (Mark < 80 && Mark > 59)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (Mark < 80 && Mark > 39)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (Mark < 40 && Mark > 0)
            {
                Console.WriteLine("Your Grade is F");
            }
            else
            {
                Console.WriteLine("**Error**");
            }
            
            Console.ReadLine();

        }
    }
}