using Homerseklet;

HomersekletAtvalto homerseklet = new HomersekletAtvalto();
homerseklet.Celsius = 25;

int fahrenheit = homerseklet.ToFahrenheit();
int fahrenheitStatic = (int)HomersekletAtvalto.CelsiusToFahrenheit(homerseklet.Celsius);

Console.WriteLine(fahrenheit);
Console.WriteLine(fahrenheitStatic);