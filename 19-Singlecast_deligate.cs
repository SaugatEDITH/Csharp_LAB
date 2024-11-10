// using System;
//     // Step 1: Define a delegate
//     public delegate void PrintMessage(string message);

//     class Program
//     {
//         // Step 2: Define a method that matches the delegate signature
//         public static void DisplayMessage(string message)
//         {
//             Console.WriteLine("Message: " + message);
//         }

//         static void Main(string[] args)
//         {
//             // Step 3: Instantiate the delegate with the method
//             PrintMessage printDel = new PrintMessage(DisplayMessage);

//             // Step 4: Invoke the delegate
//             printDel("Hello, this is a singlecast delegate example!");

//             Console.ReadKey();
        
//     }
// }
