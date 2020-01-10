using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace rht
{
    public class Lynk
    {      
      public static void AddTwo()
      {
        LynkedList lyst = new LynkedList();
        int[] data = Enumerable.Range(1,10).Select(x => x).ToArray();
        foreach (int datum in data)
        {
          lyst.Append(datum);
        }
        lyst.PrintAllNodes();
      }
    }
}