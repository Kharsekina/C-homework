// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите коордитату х первой точки");
int firstX=Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите коордитату y первой точки");
int firstY=Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите коордитату z первой точки");
int firstZ=Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("Введите коордитату х второй точки");
int secondX=Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите коордитату y второй точки");
int secondY=Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите коордитату z второй точки");
int srcondZ=Convert.ToInt32(Console.ReadLine ());

double distance= Distance(firstX, firstY, firstZ, secondX, secondY, srcondZ);
Console.WriteLine($"Расстояние между точками равно {Math.Round(distance, 2, MidpointRounding.ToZero)}");


double Distance (int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(ax-bx, 2)+ Math.Pow(ay-by, 2)+ Math.Pow(az-bz, 2));
}

