// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("введите кординаты x, точка А: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("введите кординаты y, точка А: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("введите кординаты x, точка B: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("введите кординаты y, точка B: ");
int y2 = int.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2));

Console.WriteLine($"Расстояние между координатами: {c}");