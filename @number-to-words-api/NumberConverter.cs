namespace NumberToWordsAPI;

public class NumberConverter
{
  public static string ConvertPriceToWords(double number)
  {
    (int dollars, int cents) = SeparateDouble(number < 0 ? -number : number);

    string dollarAffix = number > 1 ? "DOLLARS" : "DOLLAR";
    string dollarString = $"{dollars} {dollarAffix}";

    return dollarString;
  }

  public static string ConvertNumberToWords(int number)
  {
    if (number == 0) return "ZERO";

    int numberIndex = number - 1;
    if (number <= 9) return NumberMaps.Ones[numberIndex];
    if (number >= 11 && number <= 19) return NumberMaps.Teens[numberIndex % 10];
    if (IsMultipleOfTen(number) && number <= 90) return NumberMaps.Tens[numberIndex / 10];
    return "TEST";
  }

  private class NumberMaps
  {
    public static readonly string[] Ones =
      ["ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE"];
    public static readonly string[] Teens =
      ["ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"];
    public static readonly string[] Tens =
        ["TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"];
    public static readonly string[] BigNumbers =
        ["HUNDRED", "THOUSAND", "MILLION", "BILLION"];
  }

  private static (int, int) SeparateDouble(double number)
  {
    int integerPart = (int)Math.Floor(number);
    // Don't forget about floats here. 12.45 - 12 = 0.4499999999999993. So we round up, to two digits.
    int decimalPart = (int)Math.Round((number - integerPart) * 100, 2);

    return (integerPart, decimalPart);
  }

  private static bool IsMultipleOfTen(int number)
  {
    return number >= 10 && number % 10 == 0;
  }
}