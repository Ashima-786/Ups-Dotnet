using System;
public class Factorialsequence
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factorial Number:");
        for (int i = 1; i <= 10; i++)
        {
            int fact=1;
            for(int j=1;j<=i;j++){
                fact *= j;
            }
            Console.WriteLine(fact);
        }
    }
}
