using System;
class Person
{
    public string Name;
    public int Age;
    public string Address;
    public void DisplayPersonDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Address: " + Address);
    }
}
class Student : Person
{
    public int StudentId;
    public string Department;
    public int Mark;
    public void CalculateGrade()
    {
        Console.WriteLine("\nStudent: " + Name);
        Console.WriteLine("Marks: " + Mark);

        if (Mark >= 90)
            Console.WriteLine("Grade: S");
        else if (Mark >= 80)
            Console.WriteLine("Grade: A");
        else if (Mark >= 70)
            Console.WriteLine("Grade: B");
        else if (Mark >= 60)
            Console.WriteLine("Grade: C");
        else
            Console.WriteLine("Grade: F");
    }
}
class Teacher : Person
{
    public int TeacherId;
    public string Subject;
    public double Salary;
    public void CalculateAnnualSalary()
    {
        Console.WriteLine("Teacher: " + Name);
        Console.WriteLine("Monthly Salary: " + Salary);
        Console.WriteLine("Annual Salary: " + (Salary * 12));
    }
}
class Doctor : Person
{
    public int DoctorId;
    public string Specialization;
    public double ConsultationFee;
    public void CalculateConsultationAmount(int patients)
    {
        Console.WriteLine("Doctor: " + Name);
        Console.WriteLine("Consultation Fee: " + ConsultationFee);
        Console.WriteLine("Patients: " + patients);
        Console.WriteLine("Total Collection: " +
                          (ConsultationFee * patients));
    }
}

class CollegeManagementSystem
{
    static void Main()
    {
        Student s = new Student();
        Console.WriteLine("Enter Student Details");
        Console.Write("Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Address: ");
        s.Address = Console.ReadLine();
        Console.Write("Student ID: ");
        s.StudentId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Department: ");
        s.Department = Console.ReadLine();
        Console.Write("Marks: ");
        s.Mark = Convert.ToInt32(Console.ReadLine());
        s.CalculateGrade();
        Teacher t = new Teacher();
        Console.WriteLine("Enter Teacher Details");
        Console.Write("Name: ");
        t.Name = Console.ReadLine();
        Console.Write("Age: ");
        t.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Address: ");
        t.Address = Console.ReadLine();
        Console.Write("Teacher ID: ");
        t.TeacherId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject: ");
        t.Subject = Console.ReadLine();
        Console.Write("Monthly Salary: ");
        t.Salary = Convert.ToDouble(Console.ReadLine());
        t.CalculateAnnualSalary();
        Doctor d = new Doctor();
        Console.WriteLine("Enter Doctor Details");
        Console.Write("Name: ");
        d.Name = Console.ReadLine();
        Console.Write("Age: ");
        d.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Address: ");
        d.Address = Console.ReadLine();
        Console.Write("Doctor ID: ");
        d.DoctorId = Convert.ToInt32(Console.ReadLine());
        Console.Write("Specialization: ");
        d.Specialization = Console.ReadLine();
        Console.Write("Consultation Fee: ");
        d.ConsultationFee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Number of Patients: ");
        int patients = Convert.ToInt32(Console.ReadLine());
        d.CalculateConsultationAmount(patients);
    }
}

