//Задача №22. Работа в группах
//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел 
//от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
System.Console.WriteLine("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());
double X = 1;
double Y = 0;
while(X <= N)
{
    Y = Math.Pow(X, 2);
    X++;
    System.Console.WriteLine(Y);
}
