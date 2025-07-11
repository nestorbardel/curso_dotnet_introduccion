using System.Text.Json;
using System;

Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

string json = JsonSerializer.Serialize(myBeer);
Beer beer = JsonSerializer.Deserialize<Beer>(json);



Beer[] myBeers = new Beer[]
{
    new Beer() { Name = "Pikantus", Brand = "Erdinger" },
    new Beer() { Name = "Tuborg", Brand = "Tuborg" }
};

string json2 = JsonSerializer.Serialize(myBeers);
Beer[] myBeers2 = JsonSerializer.Deserialize<Beer[]>(json2);

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}