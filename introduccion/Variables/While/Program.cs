﻿int i = 0;
while (i < 10)
{
    System.Console.WriteLine("Iteracion de i: " + i);
    i++;
}

int j = 0;

while (j < 100)
{

    if (j == 10) break;


    System.Console.WriteLine("Iteracion de j: " + j);
    j++;
}

string[] friends = new string[6]{
    "Pancho", "Paco", "Ana", "Ruben", "Karla", "Luis",
};

int index = 0;

while (index < friends.Length)
{
    System.Console.WriteLine(friends[index]);
    index++;
}

bool run = false;

do
{
    Show();

} while (run);

static void Show()
{
    System.Console.WriteLine("Entro una vez y ya");
}




