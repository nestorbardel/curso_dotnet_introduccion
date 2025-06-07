int a = 1;
int b = 2;

Show();
Sum(3, 5);
Console.WriteLine(Mul(2,5));



static int Mul(int num1, int num2)
{
    return num1 * num2;
}

static void Sum(int num1, int num2)
{
    int num3 = num1 + num2;
    Console.WriteLine(num3);
}
static void Show()
{
    Console.WriteLine("Hola soy un texto que se imprime desde la funcion");
}