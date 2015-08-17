using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string Name, Gender;
            Console.Write("Enter your name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your gender (M/F) : ");
            Gender = Console.ReadLine();
            if (Gender == "M")
            {
                Console.WriteLine("Good Morning Mr. {0}", Name);
            }
            else if (Gender == "F")
            {
                Console.WriteLine("Good Morning Ms. {0}", Name);
            }
            else
            {
                Console.WriteLine("Wrong Input for gender.");
            }
            Console.ReadLine();
        }
    }
}