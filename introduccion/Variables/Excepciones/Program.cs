// See https://aka.ms/new-console-template for more information
try
{
    string content = File.ReadAllText(@"/Users/nestorbardel/Documents/prueba.rtf");
    System.Console.WriteLine(content);

    // string content2 = File.ReadAllText(@"/Users/nestorbardel/Documents/prueba2.rtf");
    // System.Console.WriteLine(content2);

    throw new Exception("Ocurrio algo inesperado");

}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"El archivo no existe");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}
finally
{
    Console.WriteLine($"Aqui me he ejecutado pase lo que pase");
    
}

Console.WriteLine($"Aqui se sigue ejecutando");


