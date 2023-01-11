// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // - "m" количество строк
    {
        for (int j = 0; j < n; j++) //- "n" количество столбцов// или точнее кол-во элементов в строке
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }

    }
    return result;

}

void SortNum(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int f = j + 1; f < mass.GetLength(1); f++)
            {
                if (mass[i, f] > mass[i, j])
                {
                    int souske = mass[i, j];
                    mass[i, j] = mass[i, f];
                    mass[i, f] = souske;
                }
            }
        }
    }
    Console.WriteLine();
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 10);

PrintArray(array);
SortNum(array);
PrintArray(array);
