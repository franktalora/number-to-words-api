namespace NumberToWordsAPI;

public class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddCors();

    var app = builder.Build();

    app.UseHttpsRedirection();

    // Configure CORS to work with Vite/React (Vite's default port is 5173)
    app.UseCors(policy => policy
      .WithOrigins("http://localhost:5173")
      .AllowAnyMethod()
      .AllowAnyHeader()
    );

    app.MapGet("/number-to-words-api/convert-price/{number}", (double number) =>
    {
      string words = PriceConverter.ConvertPriceToWords(number);
      return new { number, words };
    })
    .WithName("ConvertPriceToWords");

    app.Run();
  }
}
