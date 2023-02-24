//Задача №17. Напишите программу, 
//которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Quoters(int X, int Y)
{
    string result = "";
    if(X > 0 && Y > 0)
    {
        result = "Точка лежит в первой четверти";
    }
    else if(X > 0 && Y < 0)
    {
       result = "Точка лежит во второй четверти";
    }
    else if(X < 0 && Y < 0)
    {
       result = "Точка лежит в третьей четверти";
    }
    else if(X < 0 && Y > 0)
    {
       result = "Точка лежит в четвертой четверти";
    }
    else
    {
       result = "Точка лежит на оси";
    }
    return result;
}
int X = Promt("Введите X координату -> ");// = int X = Convert.ToInt32(Console.ReadLine())
int Y = Promt("Введите Y координату -> ");

string quoter = Quoters(X, Y);
Console.WriteLine(quoter);