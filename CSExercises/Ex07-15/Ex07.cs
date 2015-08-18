using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double Salary, HousingAllowance, TransportAllowance;
             
            Console.Write("Enter your Salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());

            HousingAllowance = (Salary * 10) / 100;
            
            TransportAllowance = (Salary * 3) / 100;
            
            Salary += HousingAllowance + TransportAllowance;
            
            Console.WriteLine("Your Salary plus benefit amount is {0}", Salary);
            
            Console.ReadLine();
        
        }
    }
}
