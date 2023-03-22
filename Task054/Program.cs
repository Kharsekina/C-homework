// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int col, int min, int max)
{
    int[,] mtrx = new int[rows, col];
    Random rnd = new Random();

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j],4}");
        }
        Console.WriteLine();
    }
}

void SortDescending(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < mtrx.GetLength(1); k++)
            {
                if (mtrx[i,k]<mtrx[i,minPosition]) minPosition=k;
            }
            int temp=mtrx[i,j];
            mtrx[i,j]=mtrx[i,minPosition];
            mtrx[i,minPosition]=temp;
        }
    }
}
int[,] matrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortDescending(matrix);
PrintMatrix(matrix);
