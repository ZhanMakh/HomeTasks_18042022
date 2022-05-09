// Домашнее задание. Решение задачи № 36

int [] mass = new int[5]; 
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0,100);
    Console.Write(mass[i] +" ");
}
Console.WriteLine();
int sum = 0;
for (int i = 1; i < mass.Length; i++)
{
    if(i%2!=0)
    {
        sum=sum+mass[i];
    } continue;
} Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях, равно {sum}");
