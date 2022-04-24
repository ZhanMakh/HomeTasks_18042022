// Домашнее задание. Решение задачи № 21.
Console.WriteLine("Введите координаты двух чисел: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
int length = (int) Math.Pow(x2-x1,2) + (int) Math.Pow(y2-y1,2) + (int)Math.Pow(z2-z1,2);
double result = Math.Round(Math.Sqrt(length), 2);
Console.WriteLine($"Расстояние между двумя точками равно {result}");