// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// bool CheckMatrixes(int[,] mtrx1, int[,] mtrx2)
// {
//     if(mtrx1.GetLength(1)==mtrx2.GetLength(0)) return true;
//     return false;
// }

int[,] ProductMatrix(int[,] mtrx1, int[,] mtrx2)
{
    int[,] mtrx3= new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    for (int i = 0; i < mtrx1.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx2.GetLength(1); j++)
        {
            int sumProduct=0;
            for (int k = 0; k < mtrx1.GetLength(1); k++)
            {
                int prodact=mtrx1[i,k]*mtrx2[k,j];
                sumProduct=sumProduct+ prodact;
            }
            mtrx3[i,j]=sumProduct;
        }
    }
    return mtrx3;
}


int[,] firstMatrix=CreateMatrix(2,3,0,10);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix=CreateMatrix(3,3,0,10);
PrintMatrix(secondMatrix);
Console.WriteLine();
if(firstMatrix.GetLength(1)==secondMatrix.GetLength(0))
{
    int[,] result=ProductMatrix(firstMatrix,secondMatrix);
    PrintMatrix(result);
}
else Console.WriteLine("Матрицы не подходят для умножения");
