namespace NumberToWordsAPI;

public class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    app.UseHttpsRedirection();

    app.MapGet("/number-to-words-api/convert-price/{number}", (int number) =>
    {
      string words = NumberConverter.ConvertPriceToWords(number);
      return new { number, words };
    })
    .WithName("ConvertPriceToWords");

    app.Run();
  }
}
