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
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE", ConvertNumberToWords(123));
    Assert.Equal("TWO HUNDRED AND THIRTY", ConvertNumberToWords(230));
    Assert.Equal("FIVE HUNDRED", ConvertNumberToWords(500));
    Assert.Equal("FIVE HUNDRED AND ELEVEN", ConvertNumberToWords(511));
    Assert.Equal("NINE HUNDRED AND NINETY-NINE", ConvertNumberToWords(999));
  }

  [Fact]
  public void PriceToWords_ShouldConvertDollars()
  {
    Assert.Equal("ONE DOLLAR", ConvertPriceToWords(1));
    Assert.Equal("ONE DOLLAR", ConvertPriceToWords(1.00));
    Assert.Equal("FIVE DOLLARS", ConvertPriceToWords(5));
    Assert.Equal("FIFTEEN DOLLARS", ConvertPriceToWords(15));
    Assert.Equal("TWENTY-EIGHT DOLLARS", ConvertPriceToWords(28));
    Assert.Equal("TWENTY-EIGHT DOLLARS", ConvertPriceToWords(28.000));
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS", ConvertPriceToWords(123));
    Assert.Equal("ONE HUNDRED AND THREE DOLLARS", ConvertPriceToWords(103));
  }

  [Fact]
  public void PriceToWords_ShouldConvertDollars_ForMultipleOfTen()
  {
    Assert.Equal("TEN DOLLARS", ConvertPriceToWords(10));
    Assert.Equal("ONE HUNDRED DOLLARS", ConvertPriceToWords(100));
    Assert.Equal("ONE HUNDRED AND FIFTY DOLLARS", ConvertPriceToWords(150));
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY CENTS", ConvertPriceToWords(123.40));
    Assert.Equal("ONE HUNDRED AND TWENTY DOLLARS", ConvertPriceToWords(120));
  }

  [Fact]
  public void PriceToWords_ShouldConvertCents()
  {
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND ONE CENT", ConvertPriceToWords(123.01));
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(123.45));
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(123.45272));
  }

  [Fact]
  public void PriceToWords_ShouldConvertNegativeNumber()
  {
    Assert.Equal("NEGATIVE ONE DOLLAR AND FORTY-FIVE CENTS", ConvertPriceToWords(-1.45));
    Assert.Equal("NEGATIVE ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS", ConvertPriceToWords(-123.45));
  }

  [Fact]
  public void PriceToWords_ShouldConvertCents_OnlyCents()
  {
    Assert.Equal("ONE CENT", ConvertPriceToWords(.01));
    Assert.Equal("TEN CENTS", ConvertPriceToWords(.1));
    Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(.45));
    Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(00.45));
    Assert.Equal("FORTY-FIVE CENTS", ConvertPriceToWords(00.45272));
  }
}
