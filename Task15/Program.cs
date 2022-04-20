// Домашнее задание.Решение задачи № 15.
Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 | day == 7)
{
    Console.WriteLine("Этот день недели является выходным!");
} else Console.WriteLine("Это будний день");
