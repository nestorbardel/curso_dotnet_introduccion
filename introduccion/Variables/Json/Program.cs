Beer myBeer = new Beer()
{
    Name = "Pikantus",
    Brand = "Erdinger"
};

Beer[] myBeers = new Beer[] 
{ 
    new Beer() { Name = "Pikantus", Brand = "Erdinger" },
    new Beer() { Name = "Tuborg", Brand = "Tuborg" }
};

public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}