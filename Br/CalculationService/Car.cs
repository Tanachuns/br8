namespace CalculationService;

public class Car
{
    private int WheelCircumference { get; set; } = 95;
    private int RoW { get; set; } = 13000;

    public int CalculateDistance(int liter)
    {
        int distance = ((RoW * WheelCircumference) * liter) / 100000;
        return distance;
    }
    public void PrintDistance(int liter)
    {
        int distance = this.CalculateDistance(liter);
        Console.WriteLine($@"Distance({distance} KM)");
    }
}
