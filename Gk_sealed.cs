using System;

namespace GK_Sealed
{
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
    public sealed class Parrot : Bird 
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
    public sealed class Sparrow : Bird 
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
    public sealed class India 
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
    public sealed class USA 
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
    public sealed class UK 
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
            Console.WriteLine("\nTesting Countries"); 
            India i = new India(); 
            i.Capital(); 
            i.Language(); 
            Console.WriteLine(); 
            USA u = new USA(); 
            u.Capital(); 
            u.Language(); 
        } 
    }
}
