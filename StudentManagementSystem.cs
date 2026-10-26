using System;
public class StudentManagementSystem
{
    public string name;
    public string roll_no;
    public double[] marks = new double[3];
    public double total;
    public double average;
    public string grade;
    public void ShowStudentsDetails()
    {
        Console.WriteLine("Enter Students name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter Roll no:");
        roll_no = Console.ReadLine();
        Console.WriteLine("Enter the Marks of 3 subjects:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    public void CalculateTotal()
    {
        total = 0;
        foreach (double mark in marks)
        {
            total += mark;
        }
    }
    public double CalculateAverage()
    {
        average = total / marks.Length;
        return average;
    }
    public void DisplayGrade()
    {
        if (average >= 90)
        {
            grade = "S";
        }
        else if (average >= 80)
        {
            grade = "A";
        }
        else if (average >= 70)
        {
            grade = "B";
        }
        else if (average >= 60)
        {
            grade = "C";
        }
        else if (average >= 50)
        {
            grade = "D";
        }
        else if (average >= 40)
        {
            grade = "E";
        }
        else
        {
            grade = "Fail";
        }
        Console.WriteLine("-- STUDENT REPORT CARD --");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll No: " + roll_no);
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Grade: " + grade);
    }
}
public class Student
{
    public static void Main(string[] args)
    {
        StudentManagementSystem student = new StudentManagementSystem();
        
        student.ShowStudentsDetails();
        student.CalculateTotal();
        student.CalculateAverage(); 
        student.DisplayGrade();
        Console.ReadLine();
    }
}
