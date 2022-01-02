using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._02Jan2022
{
    
    public class SampleExercise
    {
        //1                  *
        //3                 ***
        //5                *****
        //7
        public void PrintTriangle()
        {
            int steps = 0;
            do
            {
                Console.Write("PLease enter number of levels :: ");
                steps = Convert.ToInt32(Console.ReadLine());
                int stars = 1;
                for (int i = 0; i < steps; i++)
                {
                    for (int j = i; j < steps; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < stars; k++)
                    {
                        Console.Write("*");
                    }
                    stars = stars + 2;
                    Console.WriteLine();
                }
            } while (steps != 0);
            

        }

        //    *****
        //     ***
        //      *
        public void PrintTriangle180()
        {

        }

    }
}
