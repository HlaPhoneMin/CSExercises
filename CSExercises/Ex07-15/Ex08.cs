using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double TemperatureInCentigrate, TemperatureInFahrenheit;
            
            Console.Write("Enter the temperature in Centigrate : ");
            TemperatureInCentigrate = Convert.ToDouble(Console.ReadLine());
            
            TemperatureInFahrenheit = (1.8 * TemperatureInCentigrate) + 32;
            
            Console.WriteLine("Temperature in Fahrenheit : {0}", TemperatureInFahrenheit);
            
            Console.ReadLine();
        
        }
    }
}
