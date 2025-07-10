namespace Sobreescritura;

class Program
{
    static void Main(string[] args)
    {
        B b = new B();
        Console.WriteLine(b.Hi());
        Sale sale = new Sale(10);
        sale.Add(2);
        sale.Add(3);
        Console.WriteLine(sale.GetTotal());
        SaleWithTax saleWithTax = new SaleWithTax(10, 1.16m);
        saleWithTax.Add(2);
        saleWithTax.Add(3);
        Console.WriteLine(saleWithTax.GetTotal());
    }
}

public class A
{
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

public class B : A
{
    public override string Hi()
    {
        return base.Hi() + " Hola soy B";
    }
}

public class Sale
{
    private decimal[] _amounts;
    private int _n;
    private int _end;

    public Sale(int n)
    {
        this._amounts = new decimal[n];
        this._n = n;
        this._end = 0;
    }

    public void Add(decimal amount)
    {
        if (this._end < this._n)
        {
            this._amounts[_end] = amount;
            this._end++;
        }
    }

    public virtual decimal GetTotal()
    {
        decimal result = 0;
        int i = 0;
        while (i < this._amounts.Length)
        {
            result += this._amounts[i];
            i++;
        }
        return result;
    }
}

public class SaleWithTax : Sale
{
    private decimal _tax;
    public SaleWithTax(int n, decimal tax) : base(n)
    {
        this._tax = tax;
    }

    public override decimal GetTotal()
    {
        return base.GetTotal() * this._tax;
    }
    

}