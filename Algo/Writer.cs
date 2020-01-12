using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace rht.Algo
{
    public class Writer
    {
      public static void Write(int n)
      {
        
        // int range = 8;
        string process = "AlgoWriter";
        
        // set filename to loop index
        string filename = "LayerRotateLoops" + "_" + n;
        // header blob
        StringBuilder header = new StringBuilder();
        header.Append("###########" + Environment.NewLine);
        header.Append(String.Format(@"## n = {0} ##{1}", n, Environment.NewLine));
        header.Append("###########" + Environment.NewLine);
        bool append = false;
        Logger.WriteBlob(process, filename, header.ToString(), append);
        int limit = 0;
        // algo starts here
        StringBuilder ranges = new StringBuilder();
        StringBuilder layers = new StringBuilder("layer = [");
        StringBuilder last = new StringBuilder("last = [");
        StringBuilder last2 = new StringBuilder("     = [ ");
        limit = n / 2;
        foreach (var i in Enumerable.Range(0, limit + 1))
        {
          if (i == (limit + .5) || i == limit)
          {
            layers.Append(i + "]");
            last.Append((n - 1) + "-" + i + "]");
            last2.Append((n - 1 - i) + " ]");
          }
          else
          {
            layers.Append(i + ", ");
            last.Append((n - 1) + "-" + i + ", ");
            last2.Append((n - 1 - i) + ",   ");
          }
        }
        StringBuilder innerHeader = new StringBuilder();
        innerHeader.Append("################" + Environment.NewLine);
        innerHeader.Append(String.Format(@"## Inner Loop ##{0}", Environment.NewLine));
        innerHeader.Append("################" + Environment.NewLine);
        StringBuilder innerLayer = new StringBuilder();
        for (int layer = 0; layer < n / 2; layer++) {
          innerLayer.Append("################" + Environment.NewLine);
          innerLayer.Append(String.Format(@"## layer = {0} ##{1}", layer, Environment.NewLine));
          innerLayer.Append("################" + Environment.NewLine + Environment.NewLine);
          string innerI = "i = ";
          // int[] innerI = Enumerable.Range(0, (n / 2)).Select(x => x).ToArray();
          foreach (var i in Enumerable.Range(0, (n / 2)))
          {
            innerI += i + ", ";
          }
          innerLayer.Append(innerI + Environment.NewLine +Environment.NewLine);
          // first iterates
          int first = layer;
          // last changes 
          int innerLast = n - 1 - layer;
          for (int i = first; i < innerLast; i++) {
            innerLayer.Append("###########" + Environment.NewLine);
            innerLayer.Append(String.Format(@"## i = {0} ##{1}", i, Environment.NewLine));
            innerLayer.Append("###########" + Environment.NewLine + Environment.NewLine);
            innerLayer.Append(String.Format(@"first = {0}{1}", i, Environment.NewLine));
            // offset pivots about the center
            //   but for subsequent layers.. 
            int offset = i - first;
            innerLayer.Append("int offset = i - first(i)");
            innerLayer.Append(String.Format(@"{3}offset = {0} - {1} = {2}{3}{3}", i, first , offset, Environment.NewLine));
            // hold value of cell in each row / col iteration as top
            innerLayer.Append("int top = matrix[first][i]");
            innerLayer.Append(String.Format(@"{2}int top = matrix[{0}][{1}]{2}{2}", first, i, Environment.NewLine));
            
            innerLayer.Append("matrix[first][i] = matrix[innerLast - offset][first]");
            innerLayer.Append(String.Format(@"{4}matrix[{0}][{1}] = matrix[{2} - {3}][{0}]{4}{4}", first , i, innerLast, offset, Environment.NewLine));
            
            innerLayer.Append(String.Format(@"matrix[innerLast - offset][first] = matrix[innerLast][innerLast - offset]"));
            innerLayer.Append(String.Format(@"{3}matrix[{1} - {2}][{0}] = matrix[{1}][{1} - {2}]{3}{3}", first, innerLast, offset, Environment.NewLine));
            
            innerLayer.Append(String.Format(@"matrix[innerLast][innerLast - offset] = matrix[i][innerLast]"));
            innerLayer.Append(String.Format(@"{3}matrix[{1}][{1} - {2}] = matrix[{0}][{1}]{3}{3}", i, innerLast, offset, Environment.NewLine));
            
            innerLayer.Append(String.Format(@"matrix[i][innerLast] = top"));
            innerLayer.Append(String.Format(@"{2}matrix[{0}][{1}] = top{2}{2}" , i, innerLast, Environment.NewLine));
          }
        }
        ranges.Append(String.Format(@"limit = {0}{1}", limit, Environment.NewLine));
        append = true;
        ranges.Append(String.Format(@"{0}{1}", layers.ToString(), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", Regex.Replace(layers.ToString(), "layer", "first"), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", last.ToString(), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", last2.ToString(), Environment.NewLine));
        Logger.WriteBlob(process, filename, ranges.ToString(), append);
        Logger.WriteBlob(process, filename, innerHeader.ToString(), append);
        Logger.WriteBlob(process, filename, innerLayer.ToString(), append);
      }
    }
}