// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] RandomArrayD(int lenght1, int lenght2)
{
    double[,] mass = new double[lenght1, lenght2];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = Random.Shared.Next(100);
            mass[i, j] += Math.Round(Random.Shared.NextDouble(), 2);
        }
    }
    return mass;

}

void Vuvod(double[,] mass)
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


Console.WriteLine("Укажите длину 1");
int lenght1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите длину 2");
int lenght2 = Convert.ToInt32(Console.ReadLine());
double[,] myArray = new double[lenght1, lenght2];
myArray = RandomArrayD(lenght1, lenght2);
Vuvod(myArray);


