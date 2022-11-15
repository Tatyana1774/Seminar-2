/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.WriteLine("Введите любое трехзначное число");
       while(true)
    {
        string number = Console.ReadLine();
        if(!number.Equals("exit"))
            Console.WriteLine("{0}->{1}",number, number[1]);
        else
            break;
    }
