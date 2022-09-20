//Программа, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

number = Math.Abs(number);

if ((number < 1000) & (number > 99))
{
    Console.Write(number % 10);
}
else
{
    Console.Write("Число не соответствует условию задачи");
}