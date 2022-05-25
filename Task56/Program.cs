// Домашнее заданеи № 56. Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[ , ] massiv = new int[4,4];
int[] aver = new int[4];
int sum = 0;

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
    sum=0;
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        sum = sum+massiv[i,j];
    }
    aver[i]=sum;
    Console.WriteLine($"Сумма элементов в {i} строке равна {aver[i]}");
}Console.WriteLine();

int min = aver[0];
for (int i = 1; i < aver.Length; i++)
{
   if(min>aver[i])
   {
       min=aver[i];
       Console.Write($"Минимальная сумма элементов в {i} строке равна {min}");
   } 
}
