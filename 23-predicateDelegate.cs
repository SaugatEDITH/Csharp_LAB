// using System;

// namespace PredicateDelegateExample
// {
//     class Program
//     {
//         // Step 1: Define a method that matches the Predicate signature
//         public static bool IsEven(int number)
//         {
//             return number % 2 == 0;
//         }

//         static void Main(string[] args)
//         {
//             // Step 2: Instantiate a Predicate delegate
//             Predicate<int> predicateDel = IsEven;

//             // Step 3: Test the Predicate delegate
//             int number = 10;
//             bool result = predicateDel(number);

//             // Step 4: Display the result
//             Console.WriteLine($"Is {number} even? {result}");

//             Console.ReadKey();
//         }
//     }
// }
