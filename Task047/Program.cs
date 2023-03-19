// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix(int rows, int col, double max, double min)
{
    double[,] mtrx = new double[rows, col];
    Random rnd = new Random();

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            double num = rnd.NextDouble() * (max - min)+min;
            mtrx[i, j] = Math.Round(num, 1);
        }
    }
    return mtrx;
}

void PrintMatrix(double [,] mtrx)
{
   for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i,j],6}");
        }
        Console.WriteLine();
    }
}


double [,] matrix=CreateMatrix(3,4,-9.9,10.0);
PrintMatrix(matrix);

