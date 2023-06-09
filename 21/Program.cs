//  Напишите программу, которая принимает на вход координаты двух точек 
//  и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Enter first point x: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Enter first point y: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Enter first point z: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Enter second point x: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Enter second point y: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Enter second point z: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2),2)+ Math.Pow((z1-z2),2));

Console.Write("$Distance between two points is" + result);