using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_9
{
    class StringReplacer
    {
        public string stringReplace(string text1, string text2)
        {
            Random random = new Random();
            int indexOfElementInFirstString = random.Next(0, text1.Length - 1);
            int indexOfElementInSecondString = random.Next(0, text2.Length - 1);
            int numberOfElementsInFirstString = random.Next(1, text1.Length - indexOfElementInFirstString);
            int numberOfElementsInSecondString = random.Next(1, text2.Length - indexOfElementInSecondString);
            string removedElementsFromFirstString = text1.Substring(indexOfElementInFirstString, numberOfElementsInFirstString);
            string removedElementsFromSecondString = text2.Substring(indexOfElementInSecondString, numberOfElementsInSecondString);
            text1 = text1.Replace(removedElementsFromFirstString, removedElementsFromSecondString);
            return text1;
        }
    }
}
