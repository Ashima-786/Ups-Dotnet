using System;

static class StringExtension1
{
    public static void FullName(this string firstname, string middlename, string lastname)
    {
        Console.WriteLine("First Name: " + firstname);
        Console.WriteLine("Middle Name: " + middlename);
        Console.WriteLine("Last Name: " + lastname);
        if (string.IsNullOrWhiteSpace(middlename))
        {
            Console.WriteLine("Full Name: " + firstname + " " + lastname);
        }
        else if (string.IsNullOrWhiteSpace(firstname))
        {
            Console.WriteLine("Full Name: " + middlename + " " + lastname);
        }
        else if (string.IsNullOrWhiteSpace(lastname))
        {
            Console.WriteLine("Full Name: " + firstname + " " + middlename);
        }
        else
        {
            Console.WriteLine("Full Name: " + firstname + " " + middlename + " " + lastname);
        }
    }
}

class Withoutreturntype()
{
    static void Main()
    {
        string firstname = "Ashima";
        string middlename = "Jan";
        string lastname = "Alavudeen";
        firstname.FullName(middlename, lastname);
    }
}
