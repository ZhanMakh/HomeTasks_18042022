// Домашнее задание. Решение задачи № 13
Console.WriteLine("Введите любое целое число: ");
int num = int.Parse(Console.ReadLine());
if (num>=1000)
{
    num = num/10;
    num = num%10;
    Console.WriteLine($"Третья цифра в данном числе равна {num}");
} else
    if (num>=100 & num<1000)
    {
        num = num%10;
        Console.WriteLine($"Третья цифра в данном числе равна {num}");
    }
else Console.WriteLine("Третьей цифры нет");