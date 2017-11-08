using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_13
{
    class Program
    {
        static void Main(string[] args)
        {
             List<Qualification> baseQualification = new List<Qualification>()
       {
           new Qualification(300, 1, "jun"), 
           new Qualification(400,3,"middle"),
           new Qualification(550,5,"senior"),
           new Qualification(700,7,"lead") 
       };
            List<List<Qualification>> combinationOfQualification = new List<List<Qualification>>(1)
        {
            {new List<Qualification>(){baseQualification[0]}},
            {new List<Qualification>(){baseQualification[1]}},
            {new List<Qualification>(){baseQualification[2]}},
            {new List<Qualification>(){baseQualification[3]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[1]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[2]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[3]}},
            {new List<Qualification>(){baseQualification[1], baseQualification[2]}},
            {new List<Qualification>(){baseQualification[1], baseQualification[3]}},
            {new List<Qualification>(){baseQualification[2], baseQualification[3]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[1], baseQualification[2]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[1], baseQualification[3]}},
            {new List<Qualification>(){baseQualification[1], baseQualification[2], baseQualification[3]}},
            {new List<Qualification>(){baseQualification[0], baseQualification[2], baseQualification[3]}},
            {baseQualification}
        };
            string entryBudget = Console.ReadLine();
            FirstCriterium firstCriterium = new FirstCriterium(Convert.ToInt32(entryBudget), combinationOfQualification);
            Console.WriteLine(firstCriterium.algoritm());
        }
    }
}
