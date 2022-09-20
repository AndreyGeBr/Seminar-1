//Программа, которая на вход принимает число N, а на выходе показывает все целые числа в промежутке от -N до N
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

//int i = number * (-1);
int i = -number;

while (i <= number)
{
    //Console.Write(i);
    //Console.Write(", ");
    Console.Write($"{i} ");
    i = i + 1;
}


