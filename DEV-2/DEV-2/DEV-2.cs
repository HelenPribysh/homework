using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i == 0)
                    Console.WriteLine(i);
                else if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("Tutti-Frutti");
                else if (i % 3 == 0)
                    Console.WriteLine("Tutti");
                else if (i % 5 == 0)
                    Console.WriteLine("Frutti");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
