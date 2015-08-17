using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string Name, Gender; int Age;
            Console.Write("Enter your name : ");
            Name = Console.ReadLine();
            Console.Write("Enter your gender (M/F) : ");
            Gender = Console.ReadLine();
            Console.Write("Enter your age : ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Gender == "M")
            {
                if (Age > 40)
                {
                    Console.WriteLine("Good Morning Uncle {0}", Name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mr. {0}", Name);
                }
            }
            else if (Gender == "F")
            {
                if (Age > 40)
                {
                    Console.WriteLine("Good Morning Aunty {0}", Name);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms. {0}", Name);
                }
            }
            else
            {
                Console.WriteLine("Wrong Input for gender.");
            }
            
            Console.ReadLine(); 
        }
    }
}