// using System;

// namespace MulticastDelegateExample
// {
//     // Step 1: Define a delegate
//     public delegate void PrintMessage(string message);

//     class Program
//     {
//         // Step 2: Define methods that match the delegate signature
//         public static void DisplayMessage(string message)
//         {
//             Console.WriteLine("DisplayMessage: " + message);
//         }

//         public static void AnotherMessage(string message)
//         {
//             Console.WriteLine("AnotherMessage: " + message);
//         }

//         static void Main(string[] args)
//         {
//             // Step 3: Instantiate the delegate and add methods to it
//             PrintMessage printDel = DisplayMessage;
//             printDel += AnotherMessage;

//             // Step 4: Invoke the delegate (both methods will be called)
//             printDel("Hello, this is a multicast delegate example!");

//             // Optional: Remove a method from the delegate
//             printDel -= DisplayMessage;

//             Console.WriteLine("\nAfter removing DisplayMessage:");

//             // Step 5: Invoke the delegate again (only one method will be called now)
//             printDel("This is after removing DisplayMessage.");

//             Console.ReadKey();
//         }
//     }
// }
