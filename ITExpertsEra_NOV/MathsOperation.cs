using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEra_NOV
{
    public class MathsOperation
    {

        // variable
        public int var1 = 10;

        // create new variable
        public int noofseats = 6;

        public int speed = 10;
        public string colour = "Red";
        public string name = "wagnor";

        // property
        public int MyProperty { get; set; }

        // methods

        public void sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The sum of the two numbers is" + result);
        }

        public void Accelerator(int pressure)
        {
            int speed = pressure * 10;
            Console.WriteLine(speed);
        }
        public void CurrentSpeed()
        {
            Console.WriteLine("your current speed is 120kph");
        }
        public void brake(int pressure)
        {

            int speed = pressure / 10;
            Console.WriteLine("speed of the car is " + speed);
        }

    }
}