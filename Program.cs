// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1
Console.Clear();
Console.Write("Введите число  ");
int number = int.Parse(Console.ReadLine()!);
int number1 = number / 10;
while (number > 999)
{
    number = number / 10;
}
int count = 10;
int result = number1 % count;
if (number < 99)
{
    Console.WriteLine("Это не трехзначное число!");
}
else
{
    Console.WriteLine($"{result}");
}