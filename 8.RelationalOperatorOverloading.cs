using System;

class Box
{
    public int Volume { get; set; }

    public static bool operator >(Box b1, Box b2) => b1.Volume > b2.Volume;
    public static bool operator <(Box b1, Box b2) => b1.Volume < b2.Volume;

    public override string ToString() => $"Volume: {Volume}";
}

class Program
{
    static void Main()
    {
        var box1 = new Box { Volume = 30 };
        var box2 = new Box { Volume = 20 };

        Console.WriteLine(box1 > box2); // Output: True
        Console.WriteLine(box1 < box2); // Output: False
    }
}
