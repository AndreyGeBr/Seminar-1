// Программа, которая выдает название дня недели по заданному номеру
Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня");
}

//if (number == 1) Console.Write("Понедельник");
//if (number == 2) Console.Write("Вторник");
//if (number == 3) Console.Write("Среда");
//if (number == 4) Console.Write("Четверг");
//if (number == 5) Console.Write("Пятница");
//if (number == 6) Console.Write("Суббота");
//if (number == 7) Console.Write("Воскресенье");
//if (number > 7) Console.Write("Введите число от 1 до 7");
//if (number < 1) Console.Write("Введите число от 1 до 7");
