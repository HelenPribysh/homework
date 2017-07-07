using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            if (args.Length != 0)
                inputLine = string.Join(" ", args);
            else
                inputLine = Console.ReadLine();
            string[] splitArray = inputLine.Split(' ');
            int[] arrayOfNumbers = new int[splitArray.Length];
            for (int i = 0; i < splitArray.Length; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(splitArray[i]);
                //Console.WriteLine(arrayOfNumbers[i]);
            }
            bool result = false;
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                if (arrayOfNumbers[i + 1] >= arrayOfNumbers[i])
                {
                    result = true;
                    break;
                }
            }
            Console.WriteLine(result);

        }
    }
}
