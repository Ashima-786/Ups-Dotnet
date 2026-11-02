using System;
static class Calculator1 
{ 
    public static void Add(int a, int b) 
    { 
        Console.WriteLine("Addition: " + (a + b)); 
    } 
    public static void Sub(int a, int b) 
    { 
        Console.WriteLine("Subtraction: " + (a - b)); 
    } 
}

public class Calprogram 
{ 
    public static void Main(string[] args) 
    { 
        Calculator1.Add(20, 10); 
        Calculator1.Sub(20, 10); 
    } 
}
