namespace NumberToWordsAPI;

using static NumberConverter;

public class PriceConverter
{
  public static string ConvertPriceToWords(double number)
  {
    (int dollars, int cents) = SeparateDouble(number < 0 ? -number : number);

    string dollarAffix = number > 1 ? "DOLLARS" : "DOLLAR";
    string dollarString = $"{dollars} {dollarAffix}";

    return dollarString;
  }

  private static (int, int) SeparateDouble(double number)
  {
    int integerPart = (int)Math.Floor(number);
    // Don't forget about floats here. 12.45 - 12 = 0.4499999999999993. So we round up, to two digits.
    int decimalPart = (int)Math.Round((number - integerPart) * 100, 2);

    return (integerPart, decimalPart);
  }
}