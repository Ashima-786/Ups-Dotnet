using System;
public class Factorial
    {
        public static void Main(String[] args){
            Console.WriteLine("Factorial of a no:");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact=1;
            for(int i = 1; i <= n; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial " + n +"is" + fact);
        }
    }
