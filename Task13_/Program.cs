// Домашнее задание. Решение задачи № 13.
Console.WriteLine("Введите любое целое число до 10 000: ");
int num = int.Parse(Console.ReadLine());

if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num<1000)
{
    num = num%10;
    Console.WriteLine($"Третья цифра в данном числе равна {num}");
} else if(num<10000)
{
    num = num/10;
    num = num%10;
    Console.WriteLine($"Третья цифра в данном числе равна {num}");
} else Console.WriteLine("Это число больше 10000");
    