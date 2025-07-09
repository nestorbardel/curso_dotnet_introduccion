Sale mySale = new Sale(100, DateTime.Now);
mySale.total = -10;

class Sale
{
    public int total;
    DateTime date;

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }
}
