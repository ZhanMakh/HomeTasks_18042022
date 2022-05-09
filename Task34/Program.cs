// Домашнее задание. Решение задачи № 34
int [] mass = new int[5]; 
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100,999);
    Console.Write(mass[i] +" ");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i]%2==0)
    {
        count ++;
    } continue;
} Console.WriteLine($"Количество четных чисел равно {count}");