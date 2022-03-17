using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProgram
{
    public class VariousNo
    {
        public static void EnterVariousNo()
        {
            
            Console.WriteLine("\nPalindrome Numbers 100 to 300 >>");
            for (int i = 100; i <= 300; i++)
            {
                if (Palindrome(i) == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("\nPrime Numbers up to 100 >>");
            for (int i = 1; i <= 100; i++)
            {
                if (Prime(i) == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
       
        public static bool Palindrome(int num)
        {
            int num1 = num;
            int rem;
            int result = 0;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                result = (result + rem) * 10;
            }
            result /= 10;
            if (result == num1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Prime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            int div = num / 2;
            for (int i = 2; i <= div; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
