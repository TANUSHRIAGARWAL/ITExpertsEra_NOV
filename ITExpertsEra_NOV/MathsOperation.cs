﻿using System;
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
    }

}





}