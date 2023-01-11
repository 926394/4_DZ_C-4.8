// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }

    }
    return result;

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

int[] SummString(int[,] array)
{
    int[] result = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i] += array[i, j];
        }
    }

    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"{result[i]} ");
    }
    return result;
}

int BigNum(int[] big)
{
    int min = 0;
    for (int r = 0; r < big.Length; r++)
    {
        if (big[r] < big[min])
        {
            min = r;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min+1} строка");
    return min; 
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 10);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
int[] gor = SummString(array);
Console.WriteLine();
Console.WriteLine();
BigNum(gor);