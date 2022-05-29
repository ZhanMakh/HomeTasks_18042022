// Домашнее заадние № 64. Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

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