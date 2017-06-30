using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            for (int i = 0; i < 101; i++)
            {
		if (i == 0)
		    Console.WriteLine(i);
                else if (i % 3 == 0)
                    Console.WriteLine(3 * N++);
                else
                    Console.WriteLine(i);
            }
        }
    }
}
