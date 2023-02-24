//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int N1 = N%10;
System.Console.Write(N1);
int N2 = N/10%10;
System.Console.Write(N2);
int N3 = N/100%10;
System.Console.Write(N3);
int N4 = N/1000%10;
System.Console.Write(N4);
int N5 = N/10000%10;
System.Console.WriteLine(N5);
if(N1 == N5 && N2 == N4)
{
    System.Console.WriteLine("Введенное число палиндром");
}
else
{
    System.Console.WriteLine("Введенное число не палиндром");
}