using System;
public class MultiplicationTables
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Table " + i);
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "*" + j + "=" + (i * j));
            }
            Console.WriteLine();
        }
    }
}
