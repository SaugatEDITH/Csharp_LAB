// using System;
// using System.Drawing;
// class Fruit{
//     public string? Name{get;set;}
//     public string? Taste{get;set;}
//     public string? Size{get;set;}
//     public virtual void Eat(){
// Console.WriteLine($"Name:{Name} ,Size:{Size} ,Tast:{Taste}");
//     }
// }
// class Apple:Fruit{
//     //constructor set method
//    public Apple(){
//     Name = "Apple";
//     Taste="Sweet";
//     Size="Small";
//     }
// public override void Eat(){
//     Console.WriteLine($"Name:{Name} ,Size:{Size} ,Tast:{Taste}");
// }
// }
// class Oranges:Fruit{
//     //Constructor set method
//     public Oranges(){
//         Name = "Orange";
//         Taste="tangy";
//         Size="Medium";
//     }
// public override void Eat(){
//     Console.WriteLine($"Name:{Name} ,Size:{Size} ,Tast:{Taste}");
// }
// }

// class Program{
//     static void Main(string[] args){
//         Apple a=new Apple();
//         Oranges o=new Oranges();
//         a.Eat();
//         o.Eat();
//     }
// }