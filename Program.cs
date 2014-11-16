using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool[] matrix = new bool[1000];

            for (int i = 0; i < 1000; i++ )
            {
                if (i % 3 == 0 || i % 5 == 0)
                    matrix[i] = true;
                else
                    matrix[i] = false;
            }

            for (int i = 0; i < 1000; i++ )
            {
                if(matrix[i] == true)
                {
                    sum += i;
                }
            }

            Console.WriteLine("the sum is {0}",sum);
            Console.ReadKey();
            return;

        }
    }
}
