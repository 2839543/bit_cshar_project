using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chengfabiao
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("九九乘法表");

            for (int i = 1; i <= 9;i++ )
            {  
                for (int j = 1; j <= 9; j++)
                {
                   int total = i * j;
                    System.Console.Write(i + " X " + j + " = " + ( total > 9 ? total.ToString():" "+ total.ToString() ) + "  ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
