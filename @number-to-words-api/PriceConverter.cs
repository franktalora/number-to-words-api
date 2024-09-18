namespace NumberToWordsAPI;

using static NumberConverter;

public class PriceConverter
{
  public static string ConvertPriceToWords(double number)
  {
    (int dollars, int cents) = SeparateDouble(number);

    // DOLLARS $$$
    string dollarWords = ConvertNumberToWords(dollars);
    string dollarAffix = Math.Abs(dollars) > 1 ? "DOLLARS" : "DOLLAR";
    string dollarString = $"{dollarWords} {dollarAffix}";

    string words = dollarString;

    // CENTS ¢¢¢
    if (cents > 0)
    {
      string centWords = ConvertNumberToWords(cents);
      string centAffix = cents > 1 ? "CENTS" : "CENT";
      string centString = $"{centWords} {centAffix}";

      words = $"{dollarString} AND {centString}";
    }

    return words;
  }

  private static (int, int) SeparateDouble(double number)
  {
    int integerPart = (int)number;
    // Don't forget about floats here. 12.45 - 12 = 0.4499999999999993. So we round up, to two digits.
    int decimalPart = (int)Math.Round(Math.Abs(number - integerPart) * 100, 2);

    return (integerPart, decimalPart);
  }
}