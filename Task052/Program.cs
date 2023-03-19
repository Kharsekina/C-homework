// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageArray(int[,] mtrx)
{
    double[] arr = new double[mtrx.GetLength(1)];
    int x = 0;

    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        double colSum = 0;
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            colSum += mtrx[i, j];
        }
        arr[x]= Math.Round(colSum/mtrx.GetLength(0),1);
        x++;

    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    int count = arr.Length - 1;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[count]);
    Console.Write("]");
}

int[,] matrix=CreateMatrix(4,4,1,10);
PrintMatrix(matrix);
Console.WriteLine();
double[] array=AverageArray(matrix);
PrintArray(array);
