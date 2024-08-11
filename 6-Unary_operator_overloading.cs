using System;

class Counter
{
    public int Value { get; set; }

    public static Counter operator ++(Counter c) => new Counter { Value = c.Value + 1 };
    public static Counter operator --(Counter c) => new Counter { Value = c.Value - 1 };

    public override string ToString() => $"Value: {Value}";
}

class Program
{
    static void Main()
    {
        Counter c = new Counter { Value = 5 };
        Console.WriteLine(c);  // Output: Value: 5

        c++;
        Console.WriteLine(c);  // Output: Value: 6

        c--;
        Console.WriteLine(c);  // Output: Value: 5
    }
}
