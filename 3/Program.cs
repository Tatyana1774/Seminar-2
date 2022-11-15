/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Напишите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
    {
    if(number == 1)
{
    Console.WriteLine("Понедельник");
}
else if(number == 2)
{
    Console.WriteLine("Вторник");
}
else if(number == 3)
{
    Console.WriteLine("Среда");
}
else if(number == 4)
{
    Console.WriteLine("Четверг");
}
else if(number == 5)
{
    Console.WriteLine("Пятница");
}
    Console.WriteLine("Не является выходным");
    }
else
{
    if (number >= 6 || number <= 7)
    {
    if(number == 6)
{
    Console.WriteLine("Суббота");
}
else if(number == 7)
{
    Console.WriteLine("Воскресенье");
}
    {
    Console.WriteLine("Является выходным");
    }
}
    else if (number < 1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
} 
}