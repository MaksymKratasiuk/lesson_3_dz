using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson_3_dz
{
    internal class Task2
    {

        public static void palindrom()
        {
            Console.WriteLine("enter number -> ");
            string numberStr = Console.ReadLine();
            char[] charArray = numberStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedNumberStr = new string(charArray);

            if (int.TryParse(numberStr, out int number) && int.TryParse(reversedNumberStr, out int reversedNumber) && number == reversedNumber)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }


        }
    }
}
