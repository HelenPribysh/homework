using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_9
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                string firstString = "there is some kind of text";
                string secondString = "I think I can leave my university -_-";
                string thirdString = new StringReplacer().stringReplace(firstString, secondString);
                Console.WriteLine(firstString);
                Console.WriteLine(secondString);
                Console.WriteLine(thirdString);
            }
            catch (Exception) { }
        }
    }
}
