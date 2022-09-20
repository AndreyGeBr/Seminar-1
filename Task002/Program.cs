//Программа, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.Clear();

Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

int sqr = number1 / number2;

if(sqr == number2) 
{
  Console.Write("Да");  
}
else
{
    Console.Write("Нет");
}

