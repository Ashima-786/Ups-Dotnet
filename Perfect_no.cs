using System;
public class Perfect_no{
    public static void Main(string[] args) {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < num; i++) {
            if (num % i == 0) {
                sum += i;
            }
        }
        if (sum == num && num > 0) {
            Console.WriteLine(num + "is a Perfect Number.");
        } else {
            Console.WriteLine(num + " is not a Perfect Number.");
        }
    }
}
