using System;


// Using the Mynamespace so we can access Helper directly
using Mynamespace;

class Program
{
    static void Main(string[] args)
    {
        // No need to use fully qualified name; we can create an instance of Helper directly
        Helper helper = new Helper();
        helper.Greet();  // Calls the Greet method in the Helper class
    }
}
