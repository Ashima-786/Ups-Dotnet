using System;
public class Prime_rev
{
    public static void Main(String[] args) 
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int original = n;
        int reverse = 0;
        int orifact=0;
        int revfact = 0;
        for (int i = 1; i <= original; i++) 
            if (original % i == 0) {
                orifact++;
            }
        while (n > 0) {
            reverse = (reverse * 10) + (n % 10);
            n /= 10;
        }
        for (int i = 1; i <= reverse; i++) 
            if (reverse % i == 0) {
                revfact++;
            }
        if (orifact == 2 && revfact == 2) {
            Console.WriteLine("Both prime");
        }
        else {
            Console.WriteLine("Not both prime.");
        }
    }
}
    
        
        
