using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_13
{
     class Qualification
    {
         public int salary { get; set; }
         public double productivity { get; set; }
         public string title { get; set; }
         public Qualification(int salary, double productivity, string title)
         {
             this.salary = salary;
             this.productivity = productivity;
             this.title = title;
         }
    }
}
