﻿//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size, int min, int max)
{
    int[] arr= new int[size];
    Random rnd= new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i]=rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

int EvenNumber(int [] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0) count++;
    }
    return count;
}
int [] array= FillArray(5,100,999);
PrintArray(array);
Console.WriteLine();
int evenNumber=EvenNumber(array);
Console.WriteLine(evenNumber);