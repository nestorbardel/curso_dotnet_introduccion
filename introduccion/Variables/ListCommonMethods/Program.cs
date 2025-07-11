var numbers = new List<int>()
{
    4,3,5,19
};

Show(numbers);

numbers.Insert(1,6);

Show(numbers);

if (numbers.Contains(19))
{
    Console.WriteLine("Existe");
}
else
{
    Console.WriteLine("No existe");
}

int pos = numbers.IndexOf(19);
Console.WriteLine($"Posicion: {pos}");

numbers.Sort();
Show(numbers);

var numbers2 = new List<int>()
{
    200,300,400
    
};

numbers.AddRange(numbers2);

Show(numbers);

static void Show(List<int> numbers)
{
    Console.WriteLine("----Numeros----");
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}