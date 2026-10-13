using System;
public class Even
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Even numbers from 1 to 50:");
        for(int i = 2; i <50; i += 2)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
