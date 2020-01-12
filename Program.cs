using System;
using rht.FizzBuzz;
using rht.LinkedList;
using rht.Matrix;
using rht.FrogJump;

namespace rht
{
    class Program
    {
        static void Main(string[] args)
        {


          //
          //############
          //##  Logger
          //############
          //
          // string test = "test";
          // Logger.WriteLine(test, test, test);
          

          //
          //############
          //##  FizzBuzz
          //############
          //
          //FizzBuzz.GenerateBuzz(1,31);          

          //
          //############
          //##  AddTwo
          //############
          //
          //Lynk.AddTwo();

          //
          //############
          //##  Matrix Rotate
          //############
          //
          int[,] matrix3 = 
          {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
          };
          int[,] matrix4 = { 
            { 1, 2, 3, 4 }, 
            { 5, 6, 7, 8 }, 
            { 9, 10, 11, 12 }, 
            { 13, 14, 15, 16 } 
          };
          int [] row1 = { 1, 2, 3, 4 };
          int [] row2 = { 5, 6, 7, 8 };

          int [] row3 = { 9, 10, 11, 12 };
          int [] row4 = { 13, 14, 15, 16 };

          int[][] matrix4b = {
            row1,
            row2,
            row3,
            row4
          };

          // int m = matrix3.GetLength(0);
          // int n = matrix3.GetLength(1);
          // Clockwise.DisplayMatrix(matrix3, m, n);
          // Clockwise.Degree90Matrix(matrix3, m, n);

          // PrintMatrix.ToConsole(matrix3);
          // PrintMatrix.ToConsole(matrix4);
          // string filename = "4x4";
          // PrintMatrix.ToFile(filename, matrix4);
          // Console.WriteLine("Layer" + Environment.NewLine);
          // int[][] rev4b = LayerRotate.rotateMatrixBy90Degree(matrix4b, matrix4b.GetLength(0));
          // PrintMatrix.ToConsole(rev4b);
          // Console.WriteLine("Counter Clock" + Environment.NewLine);
          // PrintMatrix.ToConsole(CounterClockwise.rotate90(matrix4));
          Algo.Writer.Write(6);
        }
    }
}
