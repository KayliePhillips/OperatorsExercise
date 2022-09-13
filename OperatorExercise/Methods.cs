using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Methods
    {
        public static void AreaOfCircle()
        {
            Console.WriteLine("Please enter the radius of your circle.");
            var radius = double.Parse(Console.ReadLine());

            var areaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
        }

    }
}
