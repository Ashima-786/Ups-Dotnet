using System;
using System.Collections.Generic;
using System.Linq;

// Student Class
class Students
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public int Marks { get; set; }
}

class Linqprogram
{
    static void Main()
    {
        // Student Collection
        List<Students> students = new List<Students>
        {
            new Students { Id = 1, Name = "Arun", Department = "CSE", Marks = 85 },
            new Students { Id = 2, Name = "Priya", Department = "IT", Marks = 90 },
            new Students { Id = 3, Name = "Kumar", Department = "CSE", Marks = 45 },
            new Students { Id = 4, Name = "Divya", Department = "ECE", Marks = 75 },
            new Students { Id = 5, Name = "Ravi", Department = "IT", Marks = 35 }
        };

        // 1. WHERE - Marks below 30
        Console.WriteLine("\n1. WHERE - Marks Below 30");

        var result1 = students.Where(s => s.Marks < 30);

        foreach (var s in result1)
        {
            Console.WriteLine(s.Name + " - " + s.Marks + " - Failed");
        }

        // 2. WHERE - Marks above 80
        Console.WriteLine("\n2. WHERE - Marks Above 80");

        var result2 = students.Where(s => s.Marks > 80);

        foreach (var s in result2)
        {
            Console.WriteLine(s.Name + " - " + s.Marks + " - Topper");
        }

        // 3. GROUP BY - Department
        Console.WriteLine("\n3. GROUPING BY DEPARTMENT");

        var result3 = students.GroupBy(s => s.Department);

        foreach (var group in result3)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }

        // 4. WHERE + GROUP BY
        Console.WriteLine("\n4. TOPPERS GROUPED BY DEPARTMENT");

        var result4 = students
            .Where(s => s.Marks > 80)
            .GroupBy(s => s.Department);

        foreach (var group in result4)
        {
            Console.WriteLine("\nDepartment: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Marks);
            }
        }

        // 5. MAXIMUM MARKS
        Console.WriteLine("\n5. MAXIMUM MARKS");

        int result5 = students.Max(s => s.Marks);

        Console.WriteLine("Highest Marks: " + result5);

        // 6. MINIMUM MARKS
        Console.WriteLine("\n6. MINIMUM MARKS");

        int result6 = students.Min(s => s.Marks);

        Console.WriteLine("Lowest Marks: " + result6);

        // 7. MINIMUM MARKS IN EACH DEPARTMENT
        Console.WriteLine("\n7. MINIMUM MARKS BY DEPARTMENT");

        var result7 = students.GroupBy(s => s.Department);

        foreach (var group in result7)
        {
            Console.WriteLine("\nDepartment: " + group.Key);
            Console.WriteLine("Minimum Mark: " + group.Min(s => s.Marks));
        }
    }
}
