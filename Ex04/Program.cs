// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

Console.Clear();

int[,] CreatMatrix(int row, int column)
{
    return new int[row, column];
}

void FillMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0) - 1;
    int column = matrix.GetLength(1) - 1;
    int startnumber = 1;
    int i = 0;
    int j = 0;

    i = 0;
    for (j = 0; j <= column; j++)  matrix[i, j] = startnumber++;
    
    j = column;
    for (i = 1; i < row; i++)  matrix[i, j] = startnumber++;
        
    i = row;
    for (j = column; j >= 0; j--)  matrix[i, j] = startnumber++;
    
    j = 0;
    for ( i = row -1; i>0; i--)  matrix[i, j] = startnumber++;
    
    i = 1;
    for (j = 1; j < column; j++)  matrix[i, j] = startnumber++;

    j = column -1;
    for ( i = row -1; i<row; i++)  matrix[i, j] = startnumber++;

    i = row-1;
    j = 1;  
    matrix[i, j] = startnumber++;   
}

void PrintMatrix(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int column = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreatMatrix(4, 4);
FillMatrix(matrix);
PrintMatrix(matrix);

