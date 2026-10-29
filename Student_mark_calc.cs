using System;
public class Student_mark_calc
{
    public static void Main(string[] args)
    {
        int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
        try
        {
            Console.Write("Enter marks for Subject 1: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            if (m1 < 0 || m1 > 100){
                throw new Exception("Marks must be within 100");
            }
            Console.Write("Enter marks for Subject 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            if (m2 < 0 || m2 > 100) {
                throw new Exception("Marks must be within 100");
            }
            Console.Write("Enter marks for Subject 3: ");
            m3 = Convert.ToInt32(Console.ReadLine());
            if (m3 < 0 || m3 > 100){
                throw new Exception("Marks must be within 100");
            }
            Console.Write("Enter marks for Subject 4: ");
            m4 = Convert.ToInt32(Console.ReadLine());
            if (m4 < 0 || m4 > 100) {
                throw new Exception("Marks must be within 100");
            }
            Console.Write("Enter marks for Subject 5: ");
            m5 = Convert.ToInt32(Console.ReadLine());
            if (m5 < 0 || m5 > 100) {
                throw new Exception("Marks must be within 100");
            }
            int marks = m1 + m2 + m3 + m4 + m5;
            float percentage = (marks / 500.0f) * 100;
            Console.WriteLine("\nTotal Marks: " + marks + " / 500");
            Console.WriteLine("Percentage: " + percentage + "%");
            if (percentage >= 90)
            {
                Console.WriteLine("You Secured Grade S");
            }
            else if(percentage >= 80)
            {
                Console.WriteLine("You Secured Grade A");
            }
            else if(percentage >= 70)
            {
                Console.WriteLine("You Secured Grade B");
            }
            else if(percentage >= 60)
            {
                Console.WriteLine("You Secured Grade C");
            }
            else if(percentage >= 40)
            {
                Console.WriteLine("You Secured Grade D");
            }
            else if (percentage < 40)
            {
                Console.WriteLine("Failed U Grade :)");
            }
        }
        catch(FormatException){
            Console.WriteLine("Error: Plzz enter number only :)");
        }
        catch(Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
        finally{
            Console.WriteLine("Calculation process has ended.");
        }
    }
}
