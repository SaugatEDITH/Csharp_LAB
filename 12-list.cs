// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create a list of integers
//         List<int> numbers = new List<int>();

//         // Add elements to the list
//         numbers.Add(10);
//         numbers.Add(20);
//         numbers.Add(30);
//         numbers.Add(40);

//         // Display the list elements
//         Console.WriteLine("List elements:");
//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }

//         // Insert an element at a specific index
//         numbers.Insert(2, 25); // Inserts 25 at index 2

//         // Remove an element from the list
//         numbers.Remove(30);

//         // Display the list after removal
//         Console.WriteLine("List after operations:");
//        numbers.ForEach(X=> Console.WriteLine(X));

//         // Find the index of an element
//         int index = numbers.IndexOf(40);
//         Console.WriteLine($"Index of 40: {index}");

//         // Check if the list contains an element
//         bool contains20 = numbers.Contains(20);
//         Console.WriteLine($"List contains 20: {contains20}");

//         // Get the count of elements in the list
//         Console.WriteLine($"Number of elements in the list: {numbers.Count}");
//     }
// }
