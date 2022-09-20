//Программа, которая на вход принимает число и выдает его квадрат
Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int sqr = number * number;
int sqr2 = (int)Math.Pow(number,3);

Console.Write("Квадрат числа равен ");
Console.WriteLine(sqr);

Console.WriteLine(sqr2);