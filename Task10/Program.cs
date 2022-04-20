// Домашнее задание. Задача № 10
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());
int num1 = num%100;
int num2 = num1/10;
Console.WriteLine($"Вторая цифра в данном числе будет {num2}");
