using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace rht.Matrix
{
  public class PrintMatrix
  {
    public static void ToConsole(int[,] matrix)
    {
      int mRowsHeight = matrix.GetLength(0);
      int nColumnsWidth = matrix.GetLength(1);
      foreach (var row in Enumerable.Range(0, mRowsHeight))
      {
        foreach (var column in Enumerable.Range(0, nColumnsWidth))
        {
          Console.Write(matrix[row, column] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    public static void ToConsole(int[][] matrix)
    {
      int dimension = matrix.GetLength(0);
      foreach (var row in Enumerable.Range(0, dimension))
      {
        foreach (var column in Enumerable.Range(0, dimension))
        {
          Console.Write(matrix[row][column] + " ");
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    public static void ToFile(string filename, int[,] matrix)
    {
      Stream streem = new MemoryStream();
      int mRowsHeight = matrix.GetLength(0);
      int nColumnsWidth = matrix.GetLength(1);
      string blob = "";
      foreach (var row in Enumerable.Range(0, mRowsHeight))
      {
        string line = "";
        foreach (var column in Enumerable.Range(0, nColumnsWidth))
        {
          line += matrix[row, column] + " ";
        }
        blob += line;
        blob += Environment.NewLine;
      }
      bool append = true;
      Logger.WriteBlob("Matrix", filename, blob, append);
    }
  }
}