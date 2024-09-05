namespace CalculationService;

class Exchanger
{
    private string[] Currencies = ["WON", "USD", "YEN"];
    private decimal[] Rates = [33.72m, 0.028m, 3.4m];

    public static void Convert(decimal amountTHB, string currency)
    {
        Console.WriteLine($@"Number of converted (3,380,066.27 WON)");
    }
}