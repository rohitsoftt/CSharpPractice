using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._02Jan2022
{
    public class Loop
    {
        public void ForLoop()
        {
            //Print from 1 - 50
            for(int i = 1; i<= 50; i++)
            {
                Console.WriteLine(i);
            }

            //Print elements form array
            string[] stringArray = { "A", "B", "C", "D", "E", "F", };
            for(int i = 0; i< stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
        public void ForEach()
        {
            //Print from 1 - 50
            foreach (int i in Enumerable.Range(1, 50))
            {
                Console.WriteLine(i);
            }

            //Print elements form array
            string[] stringArray = { "A", "B", "C", "D", "E", "F", };
            foreach (string element in stringArray)
            {
                Console.WriteLine(element);
            }
        }
        public void ArrayTest()
        {
            // [ "A", "B", "C", "D" ]
            string[] stringArray = { "A", "B", "C", "D" };

            Console.WriteLine(stringArray[4]);
        }

        public void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 15);
        }
    }
}
