// using System;

// class JACKED
// {
//     public void Jagging()
//     {
//         int[][] JaggedArray = new int[][]
//         {
//             new int[] {1, 3, 5, 7},
//             new int[] {2, 4, 6, 8},
//             new int[] {3, 5, 7, 9},
//         };

//         int size = JaggedArray.Length;

//         for (int i = 0; i < size; i++)
//         {
//             int sizeOfInnerArray = JaggedArray[i].Length;
//             int SUM = 0;

//             for (int j = 0; j < sizeOfInnerArray; j++)
//             {
//                 SUM += JaggedArray[i][j];
//             }

//             Console.Write($" {SUM} ");
//         }
//     }
// }

// class Supe
// {
//     static void Main(string[] args)
//     {
//         JACKED j = new JACKED();
//         j.Jagging();
//     }
// }
