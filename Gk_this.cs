using System;
class Bird 
{
    public string name;

    public Bird(string name) 
    {
        this.name = name;
        Console.WriteLine("Bird Name: " + this.name);
    }
    
    public void MakeSound() 
    {
        Console.WriteLine("Generic Bird Sound");
    }
}

class Parrot : Bird 
{
    public Parrot() : base("Parrot") {}
    
    public new void MakeSound() 
    {
        Console.WriteLine("Parrot Sound: Whistle");
    }
}

class Sparrow : Bird 
{
    public Sparrow() : base("Sparrow") {}
    
    public new void MakeSound() 
    {
        Console.WriteLine("Sparrow Sound: Chirp");
    }
}
class Country
{
    public string countryName;
    public string capitalCity;
    public string primaryLanguage;
    public Country(string countryName, string capitalCity, string primaryLanguage) 
    {
        this.countryName = countryName;
        this.capitalCity = capitalCity;
        this.primaryLanguage = primaryLanguage;
        Console.WriteLine("Country Name: " + this.countryName);
    }
    public void Capital() 
    {
        Console.WriteLine("Capital: " + this.capitalCity);
    }
    
    public void Language() 
    {
        Console.WriteLine("Language: " + this.primaryLanguage);
    }
}
public class Gk_this 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("=== Testing Birds ===");
        Parrot p = new Parrot();
        p.MakeSound();
        
        Console.WriteLine("\n=== Testing Countries ===");
        Country india = new Country("India", "New Delhi", "Hindi and English");
        india.Capital();
        india.Language();
        
        Console.WriteLine();
        Country usa = new Country("USA", "Washington, D.C.", "English");
        usa.Capital();
        usa.Language();
    }
}
