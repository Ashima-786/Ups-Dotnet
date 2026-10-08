public class Scholarship{
        public static void Main(String[] args){
            Console.WriteLine("Enter your 12th grade: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            float fees = 100000;
            if (marks >= 90)
            {
                fees = 100000 * 0.05f;
            }
            Console.WriteLine("Your fees to be paid is"+fees);
        }
}
