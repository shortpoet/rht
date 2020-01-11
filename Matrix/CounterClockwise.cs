// https://www.geeksforgeeks.org/rotate-matrix-90-degree-without-using-extra-space-set-2/
// makes a copy

using System;
namespace rht.Matrix
{
  public class CounterClockwise
  {
    static int R = 4; 
    static int C = 4; 

  // After transpose we swap 
  // elements of column one 
  // by one for finding left 
  // rotation of matrix by 
  // 90 degree 
  static void reverseColumns(int[, ] arr) 
  { 
    for (int i = 0; i < C; i++) 
      for (int j = 0, k = C - 1; 
          j < k; j++, k--) { 
        int temp = arr[j, i]; 
        arr[j, i] = arr[k, i]; 
        arr[k, i] = temp; 
      } 
  } 
  // Function for do 
  // transpose of matrix 
  static void transpose(int[, ] arr) 
  { 
    for (int i = 0; i < R; i++) 
      for (int j = i; j < C; j++) { 
        int temp = arr[j, i]; 
        arr[j, i] = arr[i, j]; 
        arr[i, j] = temp; 
      } 
  } 

  // Function for print matrix 
  static void printMatrix(int[, ] arr) 
  { 

    for (int i = 0; i < R; i++) { 
      for (int j = 0; j < C; j++) 
        Console.Write(arr[i, j] + " "); 
      Console.WriteLine(""); 
    } 
  } 

  // Function to anticlockwise 
  // rotate matrix by 90 degree 
  public static int[,] rotate90(int[, ] arr) 
  { 
    transpose(arr); 
    reverseColumns(arr); 
    return arr;
  } 

  // Driver code 
  // static void Main() 
  // { 
  //   int[, ] arr = { { 1, 2, 3, 4 }, 
  //                   { 5, 6, 7, 8 }, 
  //                   { 9, 10, 11, 12 }, 
  //                   { 13, 14, 15, 16 } }; 

  //   rotate90(arr); 
  //   printMatrix(arr); 
  // } 

  // This code is contributed 
  // by Sam007 
  }
}