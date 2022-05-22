// Домашнее задание № 47.Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.
// m = 3, n = 4.
double[,] massiv = new double[3,4];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
         massiv[i,j] = new Random().Next(1,9)+new Random().NextDouble();
         Console.Write(Math.Round(massiv[i,j],1) +" ");
    } Console.WriteLine();
}
