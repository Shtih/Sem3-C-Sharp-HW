//Задача №21. Работа в группах
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
System.Console.WriteLine("Введите координаты Х точки А: ");
double Ax = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки А: ");
double Ay = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты X точки В: ");
double Bx = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты Y точки В: ");
double By = Convert.ToDouble(Console.ReadLine());

double lenthAB = Math.Sqrt((Math.Pow((Bx - Ax), 2) + (Math.Pow((By - Ay), 2))));
System.Console.WriteLine(Math.Round(lenthAB, 2));