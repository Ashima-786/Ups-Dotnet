public class Grade
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your Marks out of 500 ");
        int marks = Convert.ToInt32(Console.ReadLine());
        float percentage = (marks/500.0f) *100;
        if (percentage >= 90)
        {
            Console.WriteLine("You Secured Grade S");
        }
        else if(percentage>=80 && percentage <= 89)
        {
            Console.WriteLine("You Secured Grade A");
        }
        else if(percentage>=70 && percentage <= 79)
        {
            Console.WriteLine("You Secured Grade B");
        }
        else if(percentage>=60 && percentage<= 69)
        {
            Console.WriteLine("You Secured Grade C");
        }
        else if(percentage>=40 && percentage <= 59)
        {
            Console.WriteLine("You Secured Grade D");
        }
        else if (percentage < 40)
        {
            Console.WriteLine("Failed U Grade :)");
        }
    }
}
