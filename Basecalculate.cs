using System;
public class BaseCalculate
{
    public virtual int Add(int a, int b)
    {
        return a + b;
    }
}
class Child1 : BaseCalculator
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
}
class Child2 : BaseCalculator
{
    public override int Add(int a, int b)
    {
        return a - b;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        BaseCalculator c1 = new Child1();
        BaseCalculator c2 = new Child2();
        Console.WriteLine("Child 1 Add: " + c1.Add(20, 10)); 
        Console.WriteLine("Child 2 Sub: " + c2.Add(20, 10)); 
    }
}

