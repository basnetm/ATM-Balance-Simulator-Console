using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    public class loop
    {
        public void LoopPattern()
        {
            for (int i = 5; i >= 1; i--) 
            {
                for (int j = 1; j <= i; j++)  
                {
                    Console.Write(j);  
                }

                Console.WriteLine(); 
            }
        }
        public void LoopPatterns()
        {
            for (int i = 5; i >= 1; i--)   
            {
                for (int j = 1; j <= i; j++)  
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public void Space()
        {
            for (int i = 1; i <= 4; i++)  
            {
                int num = 1;

                for (int j = 1; j <= i; j++)  
                {
                    Console.Write(num + " ");
                    num += 2;  
                }

                Console.WriteLine();
            }
        }


    }
}
