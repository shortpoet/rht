// https://www.careercup.com/question?id=5667482614366208

using System;
namespace rht.Matrix
{
  public class LayerRotate
  {
    public static int[][] rotateMatrixBy90Degree(int[][] matrix, int n) {
    // layer increments up to half the length of the dimension of matrix
    for (int layer = 0; layer < n / 2; layer++) {
      // first iterates
      int first = layer;
      // last changes 
      int last = n - 1 - layer;
      for (int i = first; i < last; i++) {
        // offset pivots about the center
        //   but for subsequent layers.. 
        int offset = i - first;
        // hold value of cell in each row / col iteration as top
        int top = matrix[first][i];

        matrix[first][i] = matrix[last - offset][first];
        matrix[last - offset][first] = matrix[last][last - offset];
        matrix[last][last - offset] = matrix[i][last];
        matrix[i][last] = top;
      }
    }
    Console.WriteLine("Matrix After Rotating 90 degree:-");
    return matrix;
    }
  }
}