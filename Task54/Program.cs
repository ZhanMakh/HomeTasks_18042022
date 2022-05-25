// Домашнее задание №54.Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] massiv = new int[3,4];
int[,] num = new int[3,4];
//int save = 0;

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(1,9);
        Console.Write(massiv[i,j] +" ");
    } Console.WriteLine();
} 
Console.WriteLine();
for (int i = 0; i < massiv.GetLength(0); i++)
{
    int save = 0;
    for (int j = 0; j < massiv.GetLength(1)-1; j++)
    {
        for (int k = j+1;k < massiv.GetLength(1);k++)
        {
            if(massiv[i,j]<massiv[i,k])
            {
                save = massiv[i,j];
                massiv[i,j]=massiv[i,k];
                massiv[i,k]=save;
            } else{continue;}
        } 
    } 
} 
for (int k = 0; k < massiv.GetLength(0); k++)
{
   for (int l = 0; l < massiv.GetLength(1); l++)
   {
        num[k,l]=massiv[k,l];
        Console.Write(num[k,l] +" ");
   } Console.WriteLine();
}