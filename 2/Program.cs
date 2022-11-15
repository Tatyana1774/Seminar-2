/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine ("Введите любое число"); 

int InputNumber (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int numIn = InputNumber ($"Введите число: ");

if (numIn / 100 == 0)
    {
    Console.WriteLine ("Третьей цифры нет");
    }
    else
    {
        while (numIn > 1000)
        {
            numIn = numIn / 10;
        }
        Console.WriteLine ($"Третья цифра: {numIn % 10}"); 
    }