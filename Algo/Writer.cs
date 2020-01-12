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
        string process = "Algo";
        
        // set filename to loop index
        string filename = "LayerRotate" + "_" + n;
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
            last2.Append((n - 1) + i + " ]");
          }
          else
          {
            layers.Append(i + ", ");
            last.Append((n - 1) + "-" + i + ", ");
            last2.Append((n - 1 - i) + ",   ");
          }
        }
        for (int layer = 0; layer < n / 2; layer++) {
          // first iterates
          // int first = layer;
          // // last changes 
          // int last = n - 1 - layer;
          // for (int i = first; i < last; i++) {
          //   // offset pivots about the center
          //   //   but for subsequent layers.. 
          //   int offset = i - first;
          //   // hold value of cell in each row / col iteration as top
          //   int top = matrix[first][i];

          //   matrix[first][i] = matrix[last - offset][first];
          //   matrix[last - offset][first] = matrix[last][last - offset];
          //   matrix[last][last - offset] = matrix[i][last];
          //   matrix[i][last] = top;
          // }
        }
        ranges.Append(String.Format(@"limit = {0}{1}", limit, Environment.NewLine));
        append = true;
        ranges.Append(String.Format(@"{0}{1}", layers.ToString(), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", Regex.Replace(layers.ToString(), "layer", "first"), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", last.ToString(), Environment.NewLine));
        ranges.Append(String.Format(@"{0}{1}", last2.ToString(), Environment.NewLine));
        Logger.WriteBlob(process, filename, ranges.ToString(), append);
      }
    }
}