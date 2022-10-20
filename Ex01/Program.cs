// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] matrix = new int[4, 4]
{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7},
};

void PrintMatix(int[,] matrix)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintMatix(matrix);

int[] CreateArrRowSum(int[,] matrix)
{
    return new int[matrix.GetLength(0)];
}

int[] sum = CreateArrRowSum(matrix);

void FillArrRowSum(int[,] matrix, int[] array)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i] += matrix[i, j];
        }
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();

FillArrRowSum(matrix, sum);

int FindMinSum(int[] array)
{
    int size = array.Length;
    int minSum = array[0];
    int min = 0;
    for (int i = 0; i < size; i++)
    {
        if (sum[i] < minSum) min = i;
    }
    return min;
}

Console.WriteLine($"минимальная сумма => {FindMinSum(sum)+1} строка");
