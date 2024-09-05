namespace CalculationService;

public class Exchanger
{
    private string[] Currencies = ["WON", "USD", "YEN"];
    private decimal[] Rates = [33.72m, 0.028m, 3.4m];


    public decimal Convert(decimal amountTHB, string currency)
    {
        int index = Array.IndexOf(Currencies, currency);
        decimal converted = amountTHB * Rates[index];
        return converted;
    }

    public void PrintConvert(decimal amountTHB, string currency)
    {
        decimal converted = this.Convert(amountTHB, currency);
        Console.WriteLine($@"Number of converted({converted.ToString("#,##0.00")} {currency})");
    }
}