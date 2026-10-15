using System;
public class Palindrome{
    public static void Main(String[] args){
        Console.WriteLine("Enter a no:");
        int n=Convert.ToInt32(Console.ReadLine());
        int rev=0;
        int original=n;
        while(n>0){
            int digit=n%10;
            rev=(rev*10)+digit;
            n/=10;
        }
        if(original==rev){
            Console.WriteLine(original+"is a Palindrome");
        }
        else{
            Console.WriteLine(original+"is not a Palindrome");
        }
    }
}
