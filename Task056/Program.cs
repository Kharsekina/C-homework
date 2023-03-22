// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumArray(int[,] mtrx)
{
    int[] arr = new int[mtrx.GetLength(0)];
    int k = 0;

    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int rowsSum = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            rowsSum += mtrx[i, j];
        }
        arr[k]= rowsSum;
        k++;
    }
    return arr;
}

// void PrintArray(int[]arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//        Console.Write($"{arr[i],3}");
//     }
// }

int IndexMinSum(int[]arr)
{
    int minElement=0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]<arr[minElement]) minElement=i;
    }
    return minElement;
}


int[,] matrix=CreateMatrix(4,3,0,10);
PrintMatrix(matrix);
Console.WriteLine();
int[] sumArray=SumArray(matrix);
// Console.Write("Массив сумм элементов в строках:");
// PrintArray(sumArray);
// Console.WriteLine();
int result=IndexMinSum(sumArray);
Console.WriteLine($"Строка с наименьшей суммой элементов {result+1}");
