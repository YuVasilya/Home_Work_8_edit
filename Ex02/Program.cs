// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] CreatMatrix(int row, int col)
{
    return new int[row, col];
}

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int row1 = matrixA.GetLength(0);
    int col1 = matrixA.GetLength(1);
    int row2 = matrixB.GetLength(0);
    int col2 = matrixB.GetLength(1);
    int[,] matrixC = new int[row1, col2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            matrixC[i, j] = 0;
            for (int n = 0; n < col1; n++)
            {
                matrixC[i, j] += matrixA[i, n] * matrixB[n, j];
            }
        }
    }
    return matrixC;
}

Console.WriteLine("Matrix A");
int[,] a = CreatMatrix(2, 2);
FillMatrix(a);
PrintMatix(a);
Console.WriteLine();
Console.WriteLine("Matrix B");
int[,] b = CreatMatrix(2, 2);
FillMatrix(b);
PrintMatix(b);
Console.WriteLine();

int col1 = a.GetLength(1);
int row2 = b.GetLength(0);

if (col1 != row2)
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    
else
{
Console.WriteLine("Matrix A & B multiplication");
PrintMatix(MatrixMultiplication(a, b));
}
