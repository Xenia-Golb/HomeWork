Console.Clear();
Console.Write("Введите номер дня недели  ");
int number = int.Parse(Console.ReadLine()!);
if ( number <7 && number >= 1)
{ 
    if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else 
{
    Console.WriteLine("Будний");
}
}
else 
{
    Console.WriteLine("Введите цифру от 1 до 7");
}