// Домашнее задание № 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
int[ , ] massiv = new int[3,4];
int[ , ] copy = new int[3,4];

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(1,9);
        Console.Write(massiv[i,j] +" ");
    } Console.WriteLine();
}
if(num>massiv.Length)
{
    Console.Write("Нет такой позиции в массиве");
} else
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            copy[i,j] = massiv[i,j];
            count++;
            if(num==count)
            {
             Console.Write(massiv[i,j] + " ");
                break;
            }continue; 
        } 
    } 
}