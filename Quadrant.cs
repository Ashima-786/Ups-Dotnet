public class Quadrant
{
    public static void Main()
    {
        Console.WriteLine("Enter x value : ");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter y value:");
        int y=Convert.ToInt32(Console.ReadLine());
        if(x>0 && y>0){
                Console.WriteLine("It is Ist quadrant");
        }    
        else if(x<0 && y>0){
                Console.WriteLine("It is IInd quadrant");
        }
            else if(x<0 && y<0){
                    Console.WriteLine("Its IIIrd quadrant");
            }
            else if(x>0 &&y<0){
                    Console.WriteLine("Its Ivth quadrant");
            }
            else{
                    Console.WriteLine("does not exist");
            }
    }
}
