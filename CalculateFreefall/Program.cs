class Program
{
    static void Main(string[] args)

    {
        Console.Write("Enter the height (in meters): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double speedFinal = CalculateFreefall.CalculateVelocityFinal(height);

        Console.WriteLine($"Final velocity is: {speedFinal} m/s");
    }
    
   }