// Домашнее задание. Решение задачи № 27.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int N = number%10;
    number = number/10;
    sum = sum + N;
} Console.WriteLine($"Сумма всех цифр этого числа будет равна {sum}");
