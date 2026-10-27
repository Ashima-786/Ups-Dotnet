using System;
public class SalaryCalculator{
    public double Salarycalculate(double basic){
        return basic;
    }
    public double Salarycalculate(double basic,double allowance){
        return basic+allowance;
    }
    public double Salarycalculate(double basic,double allowance,double bonus){
        return basic+allowance+bonus;
    }
}
public class Class{
    public static void Main(string[] args){
         SalaryCalculator calc = new SalaryCalculator();
         Console.WriteLine("Enter basic salary:");
         double basic=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter allowance:");
         double allowance=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter Bonus:");
         double bonus=Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Basic Only: " + calc.Salarycalculate(basic));
         Console.WriteLine("With Allowance: " + calc.Salarycalculate(basic, allowance));
         Console.WriteLine("With Bonus: " + calc.Salarycalculate(basic, allowance, bonus));
    }
}
