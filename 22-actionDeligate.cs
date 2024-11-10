// using System;

// namespace ActionDelegateExample
// {
//     class Program
//     {
//         // Step 1: Define a method matching the Action signature
//         public static void PrintMessage(string message)
//         {
//             Console.WriteLine("Message: " + message);
//         }

//         static void Main(string[] args)
//         {
//             // Step 2: Instantiate an Action delegate
//             Action<string> actionDel = PrintMessage;

//             // Step 3: Invoke the Action delegate
//             actionDel("Hello, this is an Action delegate example!");

//             Console.ReadKey();
//         }
//     }
// }
