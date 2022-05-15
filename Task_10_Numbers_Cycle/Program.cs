using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_Numbers_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginningSequence = 5;
            int endingSequence = 100;
            int growth = 7;

            for (int number = beginningSequence; number < endingSequence; number += growth)
            {
                Console.WriteLine(number);
            }
        }  
    }
}
