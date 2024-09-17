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
  public void NumberToWords_ShouldConvertNumber()
  {
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE", ConvertNumberToWords(123));
  }

  [Fact]
  public void PriceToWords_ShouldConvertDollars()
  {
    Assert.Equal("ONE HUNDRED AND TWENTY-THREE DOLLARS", ConvertPriceToWords(123));
  }
}
