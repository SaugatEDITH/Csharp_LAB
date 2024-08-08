class Rectangle
{
    int length { get; set; }
    int width { get; set; }

    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }
    public double Area
    {
        get
        {
            return length * width;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(55, 30);
        Console.Write($"the area of Rectangle is: {rect.Area}");
    }
}