// Домашнее задание. Решение задачи № 25
Console.WriteLine("Введите два числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result = 1;
int i = 0;
while (i<B)
{
    result = result*A;
    i+=1;
} 
Console.WriteLine($"{A} ^ {B} = {result}");
