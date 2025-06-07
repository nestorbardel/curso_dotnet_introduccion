bool areYouHungry = true;
bool youHaveMoney = true;

if (areYouHungry && youHaveMoney && isOpenRestaurant("Lonches pepe", 11))
{
    Console.WriteLine("Come!!!!!");
}
else
{
    Console.WriteLine("No comas!!!!!!!");
}

static bool isOpenRestaurant(string name, int hour = 0)
{
    if (name == "Lonches pepe" && hour > 8 && hour < 23)
    {
        return true;
    }else if (name == "Restaurant 24 horas")
    {
        return true;
    }
    else
    {
        return false;
    }
}