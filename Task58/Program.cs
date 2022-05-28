// Домашнее задание № 58. Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц

int[,] mas1 = new int[3,3];
int[,] mas2 = new int[3,3];
int[,] mas3 = new int[mas1.GetLength(0),mas2.GetLength(1)];
int sum = 0;

Console.WriteLine("Первая матрица");
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i,j] = new Random().Next(1,9);
        Console.Write(mas1[i,j] +" ");
    } Console.WriteLine();
} 
Console.WriteLine("Вторая матрица");

for (int i = 0; i < mas2.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i,j] = new Random().Next(1,9);
        Console.Write(mas2[i,j] +" ");
    } Console.WriteLine();
} 
Console.WriteLine("Произведение матриц");

for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        sum = 0;
        for (int k = 0; k < mas2.GetLength(1); k++)
        {
            sum = sum + mas1[i,k] *mas2[k,j];
        } 
        mas3[i,j]=sum;
        Console.Write(mas3[i,j] +" "); 
    }   Console.WriteLine();
} 