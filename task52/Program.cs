//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.




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


double[] SR(int[,] mass)
{
    double[] result = new double[mass.GetLength(1)];
    double sr = 0.0;
    double len = (double)mass.GetLength(0);

    for (int i = 0; i < mass.GetLength(1); i++)
    {
        for (int j = 0; j < mass.GetLength(0); j++)
        {
            sr += (double)mass[j, i];
            Console.WriteLine(sr);
        }
        //break;
        result[i] = sr/len;
    }

    return result;
}

int lenght1 = 8;
int lenght2 = 5;

int[,] myArray = new int[lenght1, lenght2];

myArray = RandomArrayD(lenght1, lenght2);

double[] sr = new double[myArray.GetLength(1)];
sr = SR(myArray);

Vuvod(myArray);

Console.WriteLine($"Средняя арифметическая столбцов - {string.Join("; ", sr)}");






