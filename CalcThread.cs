using System;
using System.Threading;

class CalcThreadAdd 
{
    public static void Add(int a, int b) 
    {
        Console.WriteLine("Add start " + (a + b));
        Thread.Sleep(3000);
        Console.WriteLine("Add end");
    }
}

class CalcThreadSub 
{
    public void Sub(int a, int b) 
    {
        Console.WriteLine("Sub start " + (a - b));
        Thread.Sleep(3000);
        Console.WriteLine("Sub end ");
    }
}

class CalcThreadMul 
{
    public void Mul(int a, int b) 
    {
        Console.WriteLine("Mul start " + (a * b));
        Thread.Sleep(3000);
        Console.WriteLine("Mul end");
    }
}

class CalcThreadDiv 
{
    public void Div(int a, int b) 
    {
        Console.WriteLine("Div start " + (a / b));
        Thread.Sleep(3000);
        Console.WriteLine("Div end");
    }
}

class CalcThread 
{
    static void Main() 
    {
        Thread.CurrentThread.Name = "MainThread";

        CalcThreadSub cSub = new CalcThreadSub();
        CalcThreadMul cMul = new CalcThreadMul();
        CalcThreadDiv cDiv = new CalcThreadDiv();

        Thread t1 = new Thread(() => CalcThreadAdd.Add(12, 56));
        t1.Name = "Add"; 

        Thread t2 = new Thread(() => cSub.Sub(23, 7));
        t2.Name = "Sub";

        Thread t3 = new Thread(() => cMul.Mul(5, 6));
        t3.Name = "Mul";

        Thread t4 = new Thread(() => cDiv.Div(20, 4));
        t4.Name = "Div"; 

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();

        Console.WriteLine("CurrentThread Gets the currently executing thread: " + Thread.CurrentThread.Name);
    }
}
