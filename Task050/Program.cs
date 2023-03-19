// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

bool FindNumber(int num1, int num2, int[,] mtrx)
{
    if (num1 > mtrx.GetLength(0) - 1 || num2 > mtrx.GetLength(1) - 1) return false;
    if (num1 < 0 || num2 < 0) return false;
    return true;
}

int[,] matrix = CreateMatrix(4, 4, -10, 10);
PrintMatrix(matrix);

Console.WriteLine("Введите номер строки");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int colNumber = Convert.ToInt32(Console.ReadLine());


string output = FindNumber(rowsNumber, colNumber, matrix) ? $"Число {matrix[rowsNumber, colNumber]}" : "Такого элемента нет в массиве";
Console.WriteLine(output);

