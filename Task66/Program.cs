// Домашнее задание № 66.Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите два числа: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int length = n - m + 1;
int[] massiv = new int[length];
int sum = m;
Console.Write(m + ", ");
for (int i = 0; i < massiv.Length; i++)
    {
        if(sum<n)
        {
            sum = sum + 1;
            massiv[i] = sum;
            Console.Write(massiv[i] + ", ");
        } 
    } 
    int total = m;
    for (int i = 0; i < massiv.Length; i++)
    {
        total=total+massiv[i];
    }
    Console.WriteLine();
    Console.Write($"Сумма в данном промежутке равна {total}");
