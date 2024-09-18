namespace Tests;

using Xunit;
using static NumberToWordsAPI.NumberConverter;

public class UnitTests
{
  [Fact]
  public void NumberToWords_ShouldConvertZero()
  {
    Assert.Equal("ZERO", ConvertNumberToWords(0));
    Assert.Equal("ZERO", ConvertNumberToWords(00));
    Assert.Equal("ZERO", ConvertNumberToWords(-000));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_Ones()
  {
    Assert.Equal("ONE", ConvertNumberToWords(1));
    Assert.Equal("FOUR", ConvertNumberToWords(4));
    Assert.Equal("EIGHT", ConvertNumberToWords(8));
    Assert.Equal("NINE", ConvertNumberToWords(9));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_Teens()
  {
    Assert.Equal("ELEVEN", ConvertNumberToWords(11));
    Assert.Equal("FIFTEEN", ConvertNumberToWords(15));
    Assert.Equal("FIFTEEN", ConvertNumberToWords(15));
    Assert.Equal("NINETEEN", ConvertNumberToWords(19));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_Tens()
  {
    Assert.Equal("TEN", ConvertNumberToWords(10));
    Assert.Equal("THIRTY", ConvertNumberToWords(30));
    Assert.Equal("FIFTY", ConvertNumberToWords(50));
    Assert.Equal("NINETY", ConvertNumberToWords(90));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_TwoDigits()
  {
    Assert.Equal("TWENTY-ONE", ConvertNumberToWords(21));
    Assert.Equal("THIRTY-FIVE", ConvertNumberToWords(35));
    Assert.Equal("SIXTY-NINE", ConvertNumberToWords(69)); // Nice
    Assert.Equal("EIGHTY-TWO", ConvertNumberToWords(82));
    Assert.Equal("NINETY-NINE", ConvertNumberToWords(99));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_Hundreds()
  {
    Assert.Equal("ONE HUNDRED", ConvertNumberToWords(100));
    Assert.Equal("FIVE HUNDRED", ConvertNumberToWords(500));
    Assert.Equal("NINE HUNDRED", ConvertNumberToWords(900));
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE", ConvertNumberToWords(123));
    Assert.Equal("TWO HUNDRED AND THIRTY", ConvertNumberToWords(230));
    Assert.Equal("FIVE HUNDRED AND ELEVEN", ConvertNumberToWords(511));
    Assert.Equal("NINE HUNDRED AND NINETY-NINE", ConvertNumberToWords(999));
  }
  
  [Fact]
  public void NumberToWords_ShouldConvertNumber_Thousand()
  {
    Assert.Equal("ONE HUNDRED THOUSAND", ConvertNumberToWords(100000));
    Assert.Equal("TEN THOUSAND", ConvertNumberToWords(10000));
    Assert.Equal("ONE THOUSAND", ConvertNumberToWords(1000));
    Assert.Equal("FIVE THOUSAND", ConvertNumberToWords(5000));
    Assert.Equal("NINE THOUSAND", ConvertNumberToWords(9000));
    Assert.Equal("TWO THOUSAND THREE HUNDRED", ConvertNumberToWords(2300));
    Assert.Equal("FIVE THOUSAND ONE HUNDRED AND ONE", ConvertNumberToWords(5101));
    Assert.Equal("FIVE THOUSAND AND ELEVEN", ConvertNumberToWords(5011));
    Assert.Equal("NINE THOUSAND NINE HUNDRED AND NINETY-NINE", ConvertNumberToWords(9999));
    Assert.Equal("ONE THOUSAND AND TWENTY-THREE", ConvertNumberToWords(1023));
    Assert.Equal("ONE HUNDRED AND FIVE THOUSAND ONE HUNDRED AND TWENTY-THREE", ConvertNumberToWords(105123));
    Assert.Equal("THREE HUNDRED AND FIFTEEN THOUSAND AND FIFTY-FIVE", ConvertNumberToWords(315055));
    Assert.Equal("SIX HUNDRED THOUSAND AND TWENTY", ConvertNumberToWords(600020));
    Assert.Equal("NINE HUNDRED AND NINETY-NINE THOUSAND NINE HUNDRED AND NINETY-NINE", ConvertNumberToWords(999999));
  }

  [Fact]
  public void NumberToWords_ShouldConvertNumber_Million()
  {
    Assert.Equal("ONE MILLION", ConvertNumberToWords(1000000));
    Assert.Equal("TWO MILLION", ConvertNumberToWords(2000000));
    Assert.Equal("ONE MILLION TWO HUNDRED AND TWENTY-THREE", ConvertNumberToWords(1000223));
    Assert.Equal("SIX MILLION FIVE THOUSAND ONE HUNDRED AND ONE", ConvertNumberToWords(6005101));
    Assert.Equal("EIGHT MILLION ONE HUNDRED AND TWENTY-FIVE THOUSAND AND THIRTEEN", ConvertNumberToWords(8125013));
    Assert.Equal("SEVEN HUNDRED AND SEVENTY-SEVEN MILLION ONE HUNDRED AND TWENTY-FIVE THOUSAND NINE HUNDRED AND NINETY-NINE", ConvertNumberToWords(777125999));
  }
  
  [Fact]
  public void NumberToWords_ShouldConvertNumber_Billion()
  {
    Assert.Equal("ONE BILLION", ConvertNumberToWords(1000000000));
    Assert.Equal("TWO BILLION", ConvertNumberToWords(2000000000));  }

  // [Fact]
  // public void PriceToWords_ShouldConvertDollars()
  // {
  //   Assert.Equal("ONE DOLLAR", ConvertPriceToWords(1));
  //   Assert.Equal("ONE DOLLAR", ConvertPriceToWords(1.00));
  //   Assert.Equal("FIVE DOLLARS", ConvertPriceToWords(5));
  //   Assert.Equal("FIFTEEN DOLLARS", ConvertPriceToWords(15));
  //   Assert.Equal("TWENTY-EIGHT DOLLARS", ConvertPriceToWords(28));
  //   Assert.Equal("TWENTY-EIGHT DOLLARS", ConvertPriceToWords(28.000));
  //   Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS", ConvertPriceToWords(123));
  //   Assert.Equal("ONE HUNDRED AND THREE DOLLARS", ConvertPriceToWords(103));
  // }

  // [Fact]
  // public void PriceToWords_ShouldConvertDollars_ForMultipleOfTen()
  // {
  //   Assert.Equal("TEN DOLLARS", ConvertPriceToWords(10));
  //   Assert.Equal("ONE HUNDRED DOLLARS", ConvertPriceToWords(100));
  //   Assert.Equal("ONE HUNDRED AND FIFTY DOLLARS", ConvertPriceToWords(150));
  //   Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY CENTS", ConvertPriceToWords(123.40));
  //   Assert.Equal("ONE HUNDRED AND TWENTY DOLLARS", ConvertPriceToWords(120));
  // }

  // [Fact]
  // public void PriceToWords_ShouldConvertCents()
  // {
  //   Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND ONE CENT", ConvertPriceToWords(123.01));
  //   Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(123.45));
  //   Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(123.45272));
  // }

  // [Fact]
  // public void PriceToWords_ShouldConvertNegativeNumber()
  // {
  //   Assert.Equal("NEGATIVE ONE DOLLAR AND FORTY-FIVE CENTS", ConvertPriceToWords(-1.45));
  //   Assert.Equal("NEGATIVE ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(-123.45));
  // }

  // [Fact]
  // public void PriceToWords_ShouldConvertCents_OnlyCents()
  // {
  //   Assert.Equal("ONE CENT", ConvertPriceToWords(.01));
  //   Assert.Equal("TEN CENTS", ConvertPriceToWords(.1));
  //   Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(.45));
  //   Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(00.45));
  //   Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(00.45272));
  // }

  // [Fact]
  // // Will return an error for non-numbers
  // public void NumberToWords_ShouldThrow_ForNonNumber()
  // {
  //   object invalidInput = "invalid";
  //   Assert.Throws<InvalidCastException>(() => ConvertNumberToWords((int)invalidInput));
  //   Assert.Throws<InvalidCastException>(() => ConvertPriceToWords((int)invalidInput));
  // }
}
