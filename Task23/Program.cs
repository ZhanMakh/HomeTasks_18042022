// Домашнее задание. Решение задачи № 23
Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int index = 1;
while (index<=num)
{
    Console.Write(Math.Pow(index,3)+" ");
    index++;
}
