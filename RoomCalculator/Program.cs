
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
        Console.WriteLine("Please enter a Length amount");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a Width amount");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a height amount");
        double height = double.Parse(Console.ReadLine());

        double area = length * width; 
        Console.WriteLine("Area: " + area);

        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter: " + perimeter);
       
        //volume = length * width * height 
        //surface area = 2 (length * width) + 2 (length * height) + 2 (height * width);

        double volume = length * width * height;
        Console.WriteLine("Volume: " + volume);
        double sa = 2 * (length * width) + 2 * (length * height) + 2 * (height * width);
        Console.WriteLine("Surface Area: " + sa);
        
        if (area < 250)
        {
            Console.WriteLine("This is a small-sized room!");
        }
        else if (area > 250 && area < 650)
        {
            Console.WriteLine("This is a medium-sized room!");
        }
        else if (area > 650)
        {
            Console.WriteLine("This is a large-sized room!");
        }

        Console.WriteLine("Thank you for using the Room Detail Generator!");
    }
}