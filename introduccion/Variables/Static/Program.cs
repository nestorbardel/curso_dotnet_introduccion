People nestor = new People()
{
    Name = "Nestor",
    Age = 38
};

People juan = new People()
{
    Name = "Juan",
    Age = 38
};

System.Console.WriteLine(People.GetCount());

public static class A
{
    public static void Some()
    {
        Console.WriteLine("A");

    }
}


public class People
{
    public static int Count = 0;
    public string Name { get; set; }
    public int Age { get; set; }

    public People()
    {
        Count++;
    }

    public static string GetCount()
    {
        return $"Esta clase se ha usado {Count} veces";
    }


}