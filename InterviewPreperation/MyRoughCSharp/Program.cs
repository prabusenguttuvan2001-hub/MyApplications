/*
//Dictionary<int, object> MyDict = new Dictionary<int, object>();
//MyDict[0] = new UserProfile { name = "Prabu", age = 23 };

//foreach (var list in MyDict)
//    Console.WriteLine(list);

//public class UserProfile
//{
//    public string name { get; set; }
//    public int age { get; set; }
//}


using System.Collections.Concurrent;
using System;


//ConcurrentDictionary<int, string> cache = new ConcurrentDictionary<int, string>();

*//*// Add safely
cache.TryAdd(1, "Prabu");
cache.TryAdd(2, "Sri");

// Update safely
cache[1] = "Updated Prabu";

// Safe retrieval
if (cache.TryGetValue(1, out string value))
    Console.WriteLine(value);
*//*

class Program
{

    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        
        circle.Display();
        Console.Write(circle.Area());
 

    }
}

abstract class Shape
{
    public abstract double Area(); // abstract method

    public void Display()
    {
        Console.WriteLine("Calculating area of shape...");
    }
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
    
}




*/