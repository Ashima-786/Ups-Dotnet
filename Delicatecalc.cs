using System;
class Delicateprogram
{
    static int Sum(int x, int y)
    {
        return x + y;
    }
    static int Diff(int x, int y)
    {
        return x - y;
    }
    static int Mul(int x, int y)
    {
        return x * y;
    }
    static int Div(int x,int y){
        return x/y;
    }
    public delegate int myDelegate(int num1, int num2);
    static void Main()
    {
        myDelegate d = new myDelegate(Sum);
        Console.WriteLine("Addition: " + d(5, 6));
        d = Diff;
        Console.WriteLine("Subtraction: " + d(5, 6));
        d = Mul;
        Console.WriteLine("Multiplication: " + d(5, 6));
        d=Div;
        Console.WriteLine("Division:"+d(20,5));
    }
}
