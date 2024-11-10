// using System;

// namespace FuncDelegateExample
// {
//     class Program
//     {
//         // Step 1: Define a method that matches the Func signature
//         public static int AddNumbers(int a, int b)
//         {
//             return a + b;
//         }

//         static void Main(string[] args)
//         {
//             // Step 2: Instantiate a Func delegate
//             Func<int, int, int> funcDel = AddNumbers;

//             // Step 3: Invoke the Func delegate and display the result
//             int result = funcDel(5, 10);
//             Console.WriteLine("Result of AddNumbers: " + result);

//             Console.ReadKey();
//         }
//     }
// }
