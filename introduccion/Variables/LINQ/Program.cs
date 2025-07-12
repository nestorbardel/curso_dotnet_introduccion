
List<Beer> beers = new List<Beer>()
{
    new Beer(){
        Name = "Corona",
        Country = "Mexico"

    },
    new Beer(){
        Name = "Modelo",
        Country = "Argentina"
    },
    new Beer(){
        Name = "Stella Artois",
        Country = "Belgium"
    }
};

foreach (var beer in beers)
{
    System.Console.WriteLine(beer);
}

System.Console.WriteLine("-------------------");

//Select

var beerName = from b in beers select new { Name = b.Name, Letters = b.Name.Length, Fixed = 1 };

foreach (var beer in beerName)
{
    System.Console.WriteLine(beer);
}

System.Console.WriteLine("--------------------");

var beerNameReal = from b in beerName select new { Name = b.Name };

foreach (var beer in beerNameReal)
{
    System.Console.WriteLine(beer.Name);
}

System.Console.WriteLine("--------------------");
//where

var beerArgentina = from b in beers where b.Country == "Argentina"  || b.Country == "Belgium" select b;

foreach (var beer in beerArgentina)
{
    System.Console.WriteLine(beer);
}

System.Console.WriteLine("--------------------");

var ordererBeers = from b in beers orderby b.Country descending select b;

foreach(var beer in ordererBeers){
    System.Console.WriteLine(beer);
}





public class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, País: {Country}";
    }
}
