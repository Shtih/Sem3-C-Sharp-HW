//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите значение четверти в системе координат: ");
int quoter = Convert.ToInt32(Console.ReadLine());
if(quoter == 1)
{
    System.Console.WriteLine("Координаты Х > 0, Y > 0 ");
}
if(quoter == 2)
{
    System.Console.WriteLine("Координаты Х < 0, Y > 0");
}
if(quoter == 3)
{
    System.Console.WriteLine("Координаты Х > 0, Y < 0");
}
if(quoter == 4)
{
    System.Console.WriteLine("Координаты Х < 0, Y < 0");
}
else
{
    System.Console.WriteLine("Вы ввели не верное значение");
}