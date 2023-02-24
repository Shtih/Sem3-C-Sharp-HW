//Метод возведения в степень и вычисления корня из числа

double number = 5.23569;
double result = Math.Pow(number, 3); //возведение в степень
System.Console.WriteLine(result);
double result1 = Math.Round(number, 3); // округление, чисо в скобках до скольки символов
System.Console.WriteLine(result1);
double result2 = Math.Sqrt(number); // корень из числа
System.Console.WriteLine(result2); 
double result3 = Math.Round(Math.Sqrt(Math.Pow(number, 3)), 2);
System.Console.WriteLine(result3);