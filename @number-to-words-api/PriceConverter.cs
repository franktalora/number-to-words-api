namespace NumberToWordsAPI;

using static NumberConverter;

public class PriceConverter
{
  public static string ConvertPriceToWords(double number)
  {
    (int dollars, int cents) = SeparateDouble(number);

    string dollarString = "";
    string centString = "";

    // DOLLARS $$$
    int positiveDollars = Math.Abs(dollars);
    if (positiveDollars > 0)
    {
      string dollarWords = ConvertNumberToWords(dollars);
      string dollarAffix = positiveDollars > 1 ? "DOLLARS" : "DOLLAR";
      dollarString = $"{dollarWords} {dollarAffix}";
    }

    // CENTS ¢¢¢
    if (cents > 0)
    {
      string centWords = ConvertNumberToWords(cents);
      string centAffix = cents > 1 ? "CENTS" : "CENT";
      centString = $"{centWords} {centAffix}";
    }


    if (dollarString == "") return centString;
    if (centString == "") return dollarString;
    
    return $"{dollarString} AND {centString}";
  }

  private static (int, int) SeparateDouble(double number)
  {
    int integerPart = (int)number;
    // Don't forget about floats here. 12.45 - 12 = 0.4499999999999993. So we round up, to two digits.
    int decimalPart = (int)Math.Round(Math.Abs(number - integerPart) * 100, 2);

    return (integerPart, decimalPart);
  }
}