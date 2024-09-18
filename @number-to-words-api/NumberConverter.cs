namespace NumberToWordsAPI;

public class NumberConverter
{
  public static string ConvertNumberToWords(int number)
  {
    if (number == 0) return "ZERO";

    string words = "";
    if (number < 0)
    {
      words = "NEGATIVE ";
      number = Math.Abs(number);
    }

    if (number >= (int)BigNumberType.Billions) 
      return words + GetBigNumber(number, BigNumberType.Billions);
    if (number >= (int)BigNumberType.Millions) 
      return words + GetBigNumber(number, BigNumberType.Millions);
    if (number >= (int)BigNumberType.Thousands) 
      return words + GetBigNumber(number, BigNumberType.Thousands);

    if (number >= 100) 
      return words + GetHundreds(number);

    return words + GetNumbers(number);
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

  private enum BigNumberType
  {
    Thousands = 1000,
    Millions = 1000000,
    Billions = 1000000000
  }

  private static string GetBigNumber(int number, BigNumberType numberType)
  {
    string words = "";

    int divider = number / (int)numberType; // 6,005,123 = 6
    int remainder = number % (int)numberType; // 6,105,123 = 105,123

    if (divider >= 100)
      words += GetHundreds(divider) + " "; // SIX HUNDRED
    else
      words += GetNumbers(divider) + " "; // SIX

    int exponent = (int)Math.Floor(Math.Log10(number) / 3);
    words += NumberMaps.BigNumbers[exponent]; // MILLION

    if (remainder >= (int)BigNumberType.Thousands)
      words += $" {GetBigNumber(remainder, BigNumberType.Thousands)}"; // ONE THOUSAND ONE HUNDRED AND TWENTY-THREE
    else if (remainder >= 100)
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

  private static bool IsMultipleOfTen(int number)
  {
    return number >= 10 && number % 10 == 0;
  }
}