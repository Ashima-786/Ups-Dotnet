using System;
public class Divisible
{
    public static void Main(String[] args)
    {
        int sum=0;
        for(int i=0;i<=100;i++)
        {
            if(i%9==0)
            {
                sum+=i;
                Console.WriteLine(i);
            }
        }
    }
}
