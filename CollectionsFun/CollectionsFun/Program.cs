using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsFun
{
  class Program
  {
    static void Main(string[] args){
      var primeMinisters = new Dictionary<string, string> {
        {"JC", "James Callagha"},
        {"MT", "Margaret Thacher"},
        {"TB", "Tony Blair"}
      };
      primeMinisters["jc"] = "Jim Callaghan";  

      foreach (var pm in primeMinisters) Console.WriteLine(pm);



    }
  }
}
