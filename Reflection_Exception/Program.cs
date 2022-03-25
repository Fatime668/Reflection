using System;
using System.Reflection;

namespace Reflection_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task-1
            Console.WriteLine(isOdd(15));
            Console.WriteLine(isEven(15));

        }
        #region task-1
        public static bool isOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
