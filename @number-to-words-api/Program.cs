var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/number-to-words/{number}", (int number) =>
{
  string words = NumberToWords(number);
  return new { number, words };
})
.WithName("ConvertNumberToWords");

app.Run();

string NumberToWords(int number)
{
  if (number == 0) return "ZERO";
  if (number < 0) return $"MINUS {NumberToWords(number)}";

  return ConvertToWords(number);
}

string ConvertToWords(int number)
{
  return "ONE HUNDRED AND TWENTY-THREE DOLLARS AND FORTY-FIVE CENTS";
}
