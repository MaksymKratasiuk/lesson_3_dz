using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task1
    {
        public static void square()
        {
            Console.WriteLine("enter length of square -> ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter symbol -> ");
            string sym = Console.ReadLine();

            for(int i =0;i<length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(sym+ " ");
                }
                Console.WriteLine();
            }


        }
    }
}
