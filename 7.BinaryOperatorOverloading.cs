// using System;

// class Point
// {
//     public int X { get; set; }
//     public int Y { get; set; }

//     public static Point operator +(Point p1, Point p2) => new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
//     public static Point operator -(Point p1, Point p2) => new Point { X = p1.X - p2.X, Y = p1.Y - p2.Y };

//     public override string ToString() => $"({X}, {Y})";
// }

// class Program
// {
//     static void Main()
//     {
//         var p1 = new Point { X = 2, Y = 3 };
//         var p2 = new Point { X = 4, Y = 5 };

//         Console.WriteLine($"Sum: {p1 + p2}");           // Output: Sum: (6, 8)
//         Console.WriteLine($"Difference: {p1 - p2}");    // Output: Difference: (-2, -2)
//     }
// }
