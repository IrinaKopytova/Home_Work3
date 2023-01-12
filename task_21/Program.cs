// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X для точки A: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки A: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки A: ");
double Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки A: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double rast = Math.Round(Math.Sqrt(Math.Pow((X1 - X2), 2) + Math.Pow((Y1 - Y2), 2) + Math.Pow((Z1 - Z2), 2)), 2);

Console.WriteLine(Math.Round(rast, 2));
