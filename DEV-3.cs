using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Program
    {
       static bool fib(int n)
        {
            if (n == 0 || n == 1)
                return true;
            int fn_2 = 0, fn_1 = 1, fn = 0;
            while (fn < n)
            {
                fn = fn_2 + fn_1;
                fn_2 = fn_1;
                fn_1 = fn;
            }
            if (fn == n)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (fib(n))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
