// Домашнее задание. Решение задачи № 38
double [] mass = new double[8]; 
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0,100)+new Random().NextDouble();
    Console.Write(Math.Round(mass[i],1) +"; ");
}
Console.WriteLine();
double max = mass[0];
double min = mass[1];
for (int i = 0; i < mass.Length; i++)
{
    if(mass[i]>max)
    {
        max = mass[i];
    } else
    {
        min = mass[i];
        for (int j = 0; j < mass.Length; j++)
        {
            if(mass[j]<min)
            {
                min=mass[j];
            }
        }
    }
}Console.WriteLine($"Max = {Math.Round(max,1)}");
Console.WriteLine($"Min = {Math.Round(min,1)}");
Console.WriteLine($"Разница между максимальным и минимальным числами равна {Math.Round(max - min,1)}");
