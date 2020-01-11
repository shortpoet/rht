using System;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using rht.LinkedList;

namespace rht.LinkedList
{
    public class Lynk
    {      
      public static void AddTwo()
      {

        LynkedList lyst1 = new LynkedList();
        LynkedList lyst2 = new LynkedList();
        LynkedList revLyst1 = new LynkedList();
        LynkedList revLyst2 = new LynkedList();
        LynkedList totalLynk = new LynkedList();

        // int[] data = Enumerable.Range(1,10).Select(x => x).ToArray();
        // foreach (int datum in data)
        // {
        //   lyst.Append(datum);
        // }
        // lyst.PrintAllNodes();

        Random rnd = new Random();
        foreach (var i in Enumerable.Range(1,3))
        {
          lyst1.Append(rnd.Next(10));
          lyst2.Append(rnd.Next(10));
        }
        lyst1.PrintAllNodes();

        // lyst1.TopsyTurvy();
        // lyst1.PrintAllNodes(); 
        revLyst1 = lyst1.CopsyCurvy();
        revLyst1.PrintAllNodes();

        lyst2.PrintAllNodes();

        // lyst2.TopsyTurvy(); 
        // lyst2.PrintAllNodes();
        revLyst2 = lyst2.CopsyCurvy();
        revLyst2.PrintAllNodes();
        string count = revLyst1.Count().ToString();
        int composite1 = revLyst1.MakeComposite();
        int composite2 = revLyst2.MakeComposite();
        Console.WriteLine(String.Format(@"Count: {0}", count));
        Console.WriteLine(String.Format(@"Composite 1: {0}", composite1));
        Console.WriteLine(String.Format(@"Composite 2: {0}", composite2));

        int total = composite1 + composite2;

        Console.WriteLine(String.Format(@"Total: {0}", total));

        int[] totalArr = total.ToString().Select(x => int.Parse(x.ToString())).ToArray();

        foreach (var x in totalArr)
        {
          Console.WriteLine(x);
          totalLynk.Append(x);
        }

        totalLynk.PrintAllNodes();

      }
    }
}