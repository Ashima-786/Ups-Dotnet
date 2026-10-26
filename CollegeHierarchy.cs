using System;
public class CollegeHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string collegeName = "Kalasalingam";
            Console.Write("Enter user type (staff / student): ");
            string userType = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("\n[COLLEGE]: " + collegeName.ToUpper());
            if (userType == "staff")
            {
                Console.Write("Enter Staff Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Staff Details (Dept/Role): ");
                string details = Console.ReadLine();
                Console.Write("Enter Work Purpose: ");
                string purpose = Console.ReadLine();
                Console.WriteLine("\n[DIVISION]: STAFF");
                Console.WriteLine("[MEMBER]: Name: " + name + " | Details: " + details);
                Console.WriteLine(" [LOG]: Purpose: " + purpose);
            }
            else if (userType == "student")
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Student Details (Course/Sem): ");
                string details = Console.ReadLine();
                Console.Write("Enter Leave or Query Purpose: ");
                string purpose = Console.ReadLine();
                Console.WriteLine("\n[DIVISION]: STUDENT");
                Console.WriteLine("[MEMBER]: Name: " + name + " | Details: " + details);
                Console.WriteLine(" [LOG]: Purpose: " + purpose);
            }
            else
            {
                Console.WriteLine("Invalid user type. Please enter 'staff' or 'student'.");
            }
        }
    }
}
