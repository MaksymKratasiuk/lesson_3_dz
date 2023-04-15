using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task3
    {
        public static void filter()
        {
            Console.WriteLine("enter size of original array -> ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];

            Console.WriteLine("enter array -> ");
            for (int i = 0; i < size1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter size of filter array -> ");
            int size2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[size2];

            Console.WriteLine("enter filter array -> ");
            for (int i = 0; i < size2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            int ch = 0;
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        ch++;
                        break;
                    }
                }
            }

            int size3 = size1 - ch;
            int[] filtered_array = new int[size3];
            int index = 0;
            //           int ch = 0;
            for (int i = 0; i < size1; i++)
            {
                bool found = false;
                for (int j = 0; j < size2; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    filtered_array[index] = array1[i];
                    index++;
                }
            }


            Console.WriteLine("filtered array : ");
            foreach (int i in filtered_array)
            {
                Console.WriteLine(i + " ");

            }
            Console.WriteLine();





        }
    }
}
