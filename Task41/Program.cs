// Домашнее задание. Решение задачи № 41

int[] numbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i]=new Random().Next(-10,10);
    Console.Write(numbers[i] + " ");
} 
Console.WriteLine();

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>0){
        count++;
    }
} Console.WriteLine($"Количество положительных чисел равно {count}");