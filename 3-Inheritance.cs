// using System.Security.Cryptography.X509Certificates;

// abstract class Shape
// {
//     public abstract double CalculateArea();
// }
// class Circle : Shape
// {
//     public double radious { get; set; }
//     public Circle(double radious)
//     {
//         this.radious = radious;

//     }

//     public override double CalculateArea()
//     {
//         return Math.Round(Math.PI * Math.Pow(radious, 2), 2);
//     }
// }
// class Square : Shape
// {
//     public double Length { get; set; }
//     public Square(double Length)
//     {
//         this.Length = Length;
//     }
//     public override double CalculateArea()
//     {
//         return Math.Pow(Length, 2);
//     }
// }
// class Triangle : Shape
// {
//     public double Base { get; set; }
//     public double Height { get; set; }
//     public Triangle(double Base, double Height)
//     {
//         this.Base = Base;
//         this.Height = Height;
//     }
//     public override double CalculateArea()
//     {
//         return (Base * Height) / 2;
//     }

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Circle c = new(6);
//         Square s = new(9);
//         Triangle t = new(6, 3);
//         Console.WriteLine($"Circle Area: {c.CalculateArea()}");
//         Console.WriteLine($"Square Area: {s.CalculateArea()}");
//         Console.WriteLine($"Triangle Area: {t.CalculateArea()}");
//     }
// }
