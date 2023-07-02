//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] RandomArrayD(int lenght1, int lenght2)
{
    int[,] mass = new int[lenght1, lenght2];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Random.Shared.Next(10);
        }

    }



    return mass;

}

bool Prov(int[,] mass, int x, int y)
{

    if ((mass.GetLength(0)-1) < x || (mass.GetLength(1)-1) < y)
    {
        return false;
    }
    else
    {
        return true;
    }

}
void Vuvod(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($" Строка - {i}: ");
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + ", ");
        }
        Console.Write("\n");
    }
    Console.WriteLine("-----------------------------------------");

}
int lenght1 = 8;
int lenght2 = 5;


Console.WriteLine("Укажите строку ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец");
int y = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int[lenght1, lenght2];

myArray = RandomArrayD(lenght1, lenght2);

Vuvod(myArray);



if (Prov(myArray,x,y))
{
    Console.WriteLine($"Вот ваше число - {myArray[x,y]}");
}
else
{
    Console.WriteLine("Такого числа нет! Вы вышли за рамки масива");
}






