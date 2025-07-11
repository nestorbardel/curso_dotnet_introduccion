var nestor = new
{
    Name = "Nestor",
    Age = 38
};

Console.WriteLine($"{nestor.Name} {nestor.Age}");

var beers = new[]
{
    new{Name = "Red", Brand="Delirium"},
    new{Name = "London Porter", Brand="Fullers"}
};

foreach (var b in beers)
{
    Console.WriteLine($"{b.Name} {b.Brand}");
}