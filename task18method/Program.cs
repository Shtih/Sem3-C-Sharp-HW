//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
int Promt(string message) //строка обозначающая что мы вводим метод решения
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
bool Checked(int quater) // метод бул выводит значения или правда или лож
{
    if(quater >= 1 && quater <= 4)
    {
        return true;
    }
    else
    {
        return false;
    }
}
string[] quaters = {"x>0; y>0", "x<0; y>0", "x>0; y<0", "x<0; y<0"};
int quater = Promt("Введите четверть: ");
if(Checked(quater))
{
    System.Console.WriteLine(quaters[quater - 1]);

}
else
{
   System.Console.WriteLine("Не правильный номер четверти"); 
}