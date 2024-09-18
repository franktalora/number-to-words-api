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

    if (number >= 1000) return GetThousands(number);

    if (number >= 100) return GetHundreds(number);

    return GetNumbers(number);
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

  private static string GetThousands(int number)
  {
    string words = "";

    int thousands = number / 1000; // 205,123 = 205
    int remainder = number % 1000; // 205,123 = 123

    if (thousands >= 100)
      words += GetHundreds(thousands) + " "; // TWO HUNDRED
    else if (thousands > 0)
      words += GetNumbers(thousands) + " "; // TWO

    int exponent = (int)Math.Floor(Math.Log10(number) / 3);
    words += NumberMaps.BigNumbers[exponent]; // THOUSAND

    if (remainder >= 100)
      words += $" {GetHundreds(remainder)}"; // ONE HUNDRED AND TWENTY-THREE
    else if (remainder > 0)
      words += $" AND {GetNumbers(remainder)}"; // AND TWENTY-THREE

    return words;
  }

  private static string GetHundreds(int number)
  {
    string words = "";

    int rounded = number / 100; // Round down to the nearest one
    string firstPart = NumberMaps.Ones[rounded - 1]; // ONE
    words += $"{firstPart} {NumberMaps.BigNumbers[0]}"; // ONE HUNDRED

    int remainder = number % 100; // TWENTY-THREE
    if (remainder > 0)
    {
      words += $" AND {GetNumbers(remainder)}"; // ONE HUNDRED AND TWENTY-THREE
    }

    return words;
  }

  private static string GetNumbers(int number)
  {
    string words = "";

    // Get ones (1 to 9)
    if (number <= 9) words += NumberMaps.Ones[number - 1];

    // Get teens (11 to 19)
    else if (number >= 11 && number <= 19) words += NumberMaps.Teens[(number - 1) % 10];

    // Get multiple of ten up to 90 (eg. 10, 50, 90)
    else if (number <= 90 && IsMultipleOfTen(number))
    {
      words += NumberMaps.Tens[(number - 1) / 10];
    }

    // Get two digits up to 99 (eg. 22, 55, 87)
    else if (number >= 21 && number <= 99)
    {
      int rounded = number / 10; // Round down to the nearest ten
      int remainder = number % 10;
      string firstPart = NumberMaps.Tens[rounded - 1];
      string secondPart = NumberMaps.Ones[remainder - 1];
      words += $"{firstPart}-{secondPart}";
    }

    return words;
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