using System;
public class Bird 
{
    public Bird(string name) 
    {
        Console.WriteLine("Bird Name: " + name);
    }
    public void MakeSound() 
    {
        Console.WriteLine("Generic Bird Sound");
    }
}
class Parrot : Bird 
{
    public Parrot() : base("Parrot") 
    {
        Console.WriteLine("Parrot Constructor");
    }
    public new void MakeSound() 
    {
        Console.WriteLine("Parrot Sound: Whistle");
    }
}
class Sparrow : Bird 
{
    public Sparrow() : base("Sparrow") 
    {
        Console.WriteLine("Sparrow Constructor");
    }
    public new void MakeSound() 
    {
        Console.WriteLine("Sparrow Sound: Chirp");
    }
}
class India 
{
    public India() 
    {
        Console.WriteLine("Country Name: India");
    }
    
    public void Capital() 
    {
        Console.WriteLine("Capital: New Delhi");
    }
    
    public void Language() 
    {
        Console.WriteLine("Language: Hindi and English");
    }
}
class USA 
{
    public USA() 
    {
        Console.WriteLine("Country Name: USA");
    }
    
    public void Capital() 
    {
        Console.WriteLine("Capital: Washington, D.C.");
    }
    public void Language() 
    {
        Console.WriteLine("Language: English");
    }
}
class UK 
{
    public UK() 
    {
        Console.WriteLine("Country Name: UK");
    }
    
    public void Capital() 
    {
        Console.WriteLine("Capital: London");
    }
    
    public void Language() 
    {
        Console.WriteLine("Language: English");
    }
}
public class GK 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Testing Birds");
        Parrot p = new Parrot();
        p.MakeSound();
        
        Console.WriteLine("Testing Countries");
        India i = new India();
        i.Capital();
        i.Language();
        Console.WriteLine();
        USA u = new USA();
        u.Capital();
        u.Language();
    }
}
