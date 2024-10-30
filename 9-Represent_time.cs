// using System;

// class Time
// {
//     private int Hours { get; set; }
//     private int Minutes { get; set; }
//     private int Seconds { get; set; }

//     // Constructor to initialize hours, minutes, and seconds
//     public Time(int hours, int minutes, int seconds)
//     {
//         Hours = hours % 24;  // Ensure hours wrap around 24
//         Minutes = minutes % 60;  // Ensure minutes wrap around 60
//         Seconds = seconds % 60;  // Ensure seconds wrap around 60
//     }

//     // Method to display time in HH:MM:SS format
//     public void DisplayTime()
//     {
//         Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");
//     }

//     // Overloading + operator to add two Time objects
//     public static Time operator +(Time t1, Time t2)
//     {
//         int newSeconds = t1.Seconds + t2.Seconds;
//         int carryMinutes = newSeconds / 60;
//         newSeconds %= 60;

//         int newMinutes = t1.Minutes + t2.Minutes + carryMinutes;
//         int carryHours = newMinutes / 60;
//         newMinutes %= 60;

//         int newHours = (t1.Hours + t2.Hours + carryHours) % 24;

//         return new Time(newHours, newMinutes, newSeconds);
//     }

//     // Overloading < operator to compare two Time objects
//     public static bool operator <(Time t1, Time t2)
//     {
//         if (t1.Hours < t2.Hours)
//             return true;
//         else if (t1.Hours == t2.Hours && t1.Minutes < t2.Minutes)
//             return true;
//         else if (t1.Hours == t2.Hours && t1.Minutes == t2.Minutes && t1.Seconds < t2.Seconds)
//             return true;
//         else
//             return false;
//     }

//     // Overloading > operator for completeness in comparison
//     public static bool operator >(Time t1, Time t2)
//     {
//         return !(t1 < t2) && !(t1.Equals(t2));
//     }

//     // Override Equals to support comparison
//     public override bool Equals(object obj)
//     {
//         if (obj == null || GetType() != obj.GetType())
//             return false;

//         Time t = (Time)obj;
//         return (Hours == t.Hours) && (Minutes == t.Minutes) && (Seconds == t.Seconds);
//     }

//     // Override GetHashCode to avoid warning when overriding Equals
//     public override int GetHashCode()
//     {
//         return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create two Time objects
//         Time time1 = new Time(10, 45, 30);
//         Time time2 = new Time(5, 30, 45);

//         // Display initial times
//         Console.Write("Time 1: ");
//         time1.DisplayTime();

//         Console.Write("Time 2: ");
//         time2.DisplayTime();

//         // Add the two times using overloaded + operator
//         Time timeSum = time1 + time2;
//         Console.Write("Sum of Time 1 and Time 2: ");
//         timeSum.DisplayTime();

//         // Compare the two times using overloaded < operator
//         if (time1 < time2)
//             Console.WriteLine("Time 1 is less than Time 2");
//         else
//             Console.WriteLine("Time 1 is greater than or equal to Time 2");
//     }
// }
