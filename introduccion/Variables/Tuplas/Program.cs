// See https://aka.ms/new-console-template for more information
(int id, string name) product = (1, "Nestor");
Console.WriteLine($"product: {product.id} {product.name}");
product.name = "Lola";
Console.WriteLine($"producto.name: {product.name}");
var person = (1, "Hector");
// Console.WriteLine($"{person.Item1} - {person.Item2}");
var people = new[]
{
    (1, "Hector"),
    (2, "Lola"),
    (3, "Ema")
};

foreach (var p in people)
{
    Console.WriteLine($"{p.Item1} - {p.Item2}");
}

(int id, string name)[] people2 = new[]
{
    (1, "Hector"),
    (2, "Lola"),
    (3, "Ema")
};

foreach (var p in people2)
{
    Console.WriteLine($"{p.id} - {p.name}");
}

var cityInfo = GetLocation();
Console.WriteLine($"Lat: {cityInfo.lat} - Long: {cityInfo.lng} - Name: {cityInfo.name}");

var (_, lon, _) = GetLocation();
Console.WriteLine($"Lon: {lon}");

static (float lat, float lng, string name) GetLocation()
{
    float lat = 19.1211f;
    float lng = -99.19212f;
    string name = "CDMX";

    return (lat, lng, name);
}