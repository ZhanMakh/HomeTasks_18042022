// Домашнее задание. Решение задачи № 19
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int x1 = num/10000;
int x21 = num/1000;
int x2 = x21%10;
int x41 = num%100;
int x4 = x41/10;
int x5 = num%10;
if (x1==x5 & x2==x4) 
{
    Console.WriteLine($"Число {num} является палиндромом");
} else 
{
    Console.WriteLine($"Число {num} не является палиндромом");
}
