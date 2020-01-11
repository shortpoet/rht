// https://www.csharp-console-examples.com/loop/for-loop/rotate-matrix-to-90-degree-in-c/
// makes a copy

using System;

namespace rht.Matrix
{
    public class Clockwise
    {
      public static void DisplayMatrix(int[,] arry, int m, int n)
      {
          for (int i = 0; i < m; i++)
          {
              for (int j = 0; j < n; j++)
              {
                  Console.Write(arry[i, j] + " ");
              }
              Console.WriteLine();
          }
          Console.WriteLine();
      }
      public static void Degree90Matrix(int[,] arry, int m, int n)
      {
          int j = 0;
          int p = 0;
          int q = 0;
          int i = m - 1;
          int[,] rotatedArr = new int[m, n];

          //for (int i = m-1; i >= 0; i--)
          for (int k = 0; k < m; k++)
          {

              while (i >= 0)
              {
                  rotatedArr[p, q] = arry[i, j];
                  q++;
                  i--;
              }
              j++;
              i = m - 1;
              q = 0;
              p++;

          }
          DisplayMatrix(rotatedArr, m, n);

      }

    }
}