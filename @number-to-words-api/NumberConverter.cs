namespace NumberToWordsAPI;

public class NumberConverter
{
  public static string ConvertPriceToWords(int number)
  {
    string words = ConvertNumberToWords(number);

    string dollarAffix = number > 1 ? "DOLLARS" : "DOLLAR";
    string dollarString = $"{words} {dollarAffix}";

    return dollarString;
  }

  public static string ConvertNumberToWords(int number)
  {
    if (number == 0) return "ZERO";

    string words = "ONE HUNDRED AND TWENTY-THREE";

    if (number < 0) words = $"NEGATIVE {words}";

    return words;
  }
}