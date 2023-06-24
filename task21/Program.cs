// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] aCoordinates = new int[3];
System.Console.WriteLine("введите х первый: ");
aCoordinates[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите у первый: ");
aCoordinates[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z первый: ");
aCoordinates[2] = Convert.ToInt32(Console.ReadLine());

int[] bCoordinates = new int[3];
System.Console.WriteLine("введите х второй ");
bCoordinates[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите у второй");
bCoordinates[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите z второй");
bCoordinates[2] = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Math.Pow((bCoordinates[0] - aCoordinates[0]), 2)) + (Math.Pow((bCoordinates[1] - aCoordinates[1]), 2)) + (Math.Pow((bCoordinates[2] - aCoordinates[2]), 2)));
System.Console.WriteLine(Math.Round(result, 2));