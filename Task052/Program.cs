// Домашнее задание № 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[ , ] massiv = new int[3,4];
double[] aver = new double[4];
double sum = 0;

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(1,9);
        Console.Write(massiv[i,j] +" ");
    } Console.WriteLine();
} 
Console.WriteLine();
for (int i = 0; i < massiv.GetLength(1); i++)
{
    sum=0;
    for (int j = 0; j < massiv.GetLength(0); j++)
    {
        sum = sum+massiv[j,i];
    }
    aver[i]=sum/massiv.GetLength(0);
    Console.Write(Math.Round(aver[i],1)+ ";" +" ");
}