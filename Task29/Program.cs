// Домашнее задание. Решение задачи № 29
int[] massiv = new int[8] {1, 34, 5, 0, 4, 2, 56, 3};
for(int i=0; i<massiv.Length; i++)
{
    Console.Write(massiv[i] + " ");
}
Console.WriteLine();

// Второй рандомный способ
int[] numbers = new int[8];
for(int i=0; i<numbers.Length; i++)
{
    numbers[i]=new Random().Next(2,9);
    Console.Write(numbers[i] + " ");
} 