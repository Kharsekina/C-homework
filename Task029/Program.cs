// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int [] array= new int [8];
FullArray(array);
// ShowtArray(array);
// Console.WriteLine();
PrintArray(array);



void FullArray( int [] arr)
{
    Random rnd= new Random();
    for(int i =0; i<arr.Length; i++)
    {
        arr[i]=rnd.Next(0,100);
    }
}

// void ShowtArray(int [] arr)
// {
//     int count= arr.Length;
//     for(int i=0; i< count; i++)
//     {
//         Console.Write($"{arr[i]}  ");
//     }
   
// }

void PrintArray(int [] arr)
{
    Console.Write("[");
    int count= arr.Length-1;
    for(int i=0; i< count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[count]);
    Console.Write("]");
}





