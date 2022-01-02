using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._02Jan2022
{
    public class Condition
    {
        //If else conditions
        public void IfElse()
        {
            int i = 50;
            if (i == 10)
            {
                Console.WriteLine("Numeber is equal to 10");
            }
            else if (i <= 20)
            {
                Console.WriteLine("Number is less equal than 20");
            }
            else
            {
                Console.WriteLine("else");
            }
        }
        //Equals to 
        public void EqualsTo()
        {
            int i = 0, j = 10;
            if (i == j)
            {
                Console.WriteLine("i i sequal to j");
            }
            else
            {
                Console.WriteLine("i is not equal to j");
            }
        }
    }
}
