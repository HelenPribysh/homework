using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_13
{
    class FirstCriterium
    {
        private int budget { get; set; }
        private List<List<Qualification>> combinationOfQualification { get; set;}
        public FirstCriterium(int budget, List<List<Qualification>> combinationOfQualification)
        {
            this.budget = budget;
            this.combinationOfQualification = combinationOfQualification;
        } 
        public int[] algoritm()
        {
            Dictionary<double, List<Qualification>> qualificationAndProductivity = new Dictionary<double, List<Qualification>>();
            foreach (List<Qualification> value in combinationOfQualification) 
            {
                List<Qualification> stringOfCombinationList = value;
                List<Qualification> numberOfOneQualification = new List<Qualification>();                
                bool flag = true;
                while (flag)
                {
                    flag = false;
                    foreach (Qualification qualification in stringOfCombinationList)
                    {
                        if (!(budget - qualification.salary < 0))
                        {
                            numberOfOneQualification.Add(qualification);
                            flag = true;
                        }
                        else break;
                    }
                }
                qualificationAndProductivity.Add(getProductivity(numberOfOneQualification),numberOfOneQualification);
            }
            return getNumberOfPair(qualificationAndProductivity);
        }
        private double getProductivity(List<Qualification> combinationsOfGuys)
        {
            double productivity = 0;
            foreach (Qualification qualification in combinationsOfGuys)
            {
                productivity += qualification.productivity; 
            }
            return productivity;
        }
        private int[] getNumberOfPair(Dictionary<double, List<Qualification>> productivityOfExistingCombination)
        {
            int[] finalNumberOfGuys = {0,0,0,0};
               foreach (KeyValuePair<double, List<Qualification>> keyValue in productivityOfExistingCombination)
               {
                   if (productivityOfExistingCombination.Keys.Max().Equals(keyValue.Key))
                   {
                       List<Qualification> teamWhithMaxProductivity = keyValue.Value;
                       foreach (Qualification nameOfQualification in teamWhithMaxProductivity)
                       {
                           string title = nameOfQualification.title;
                           switch (title)
                           {
                               case "jun":
                                   finalNumberOfGuys[0]++;
                                   break;
                               case "middle":
                                   finalNumberOfGuys[1]++;
                                   break;

                               case "senior":
                                   finalNumberOfGuys[2]++;
                                   break;

                               default:
                                   finalNumberOfGuys[3]++;
                                   break;

                           }
                       }
                   }
                   
               }
               return finalNumberOfGuys;    
                       
        }
    }
}
