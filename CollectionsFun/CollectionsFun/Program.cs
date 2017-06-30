using System;
using System.Collections.Generic;

namespace CollectionsFun
{
  class Program
  {
    static void Main(string[] args){
      var primeMinisters = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
        {"JC", "James Callagha"},
        {"MT", "Margaret Thacher"},
        {"TB", "Tony Blair"}
      };
      primeMinisters["jc"] = "Jim Callaghan";  

      foreach (var pm in primeMinisters) Console.WriteLine(pm);



    }
  }
}
