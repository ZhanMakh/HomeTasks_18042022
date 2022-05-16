// 49
int[ , ] massiv = new int[6,6];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(1,9);
    }
}
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write(massiv[i,j] +" ");
    }Console.WriteLine();
}
for (int i = 0; i < massiv.GetLength(0); i+=2)
{
    for (int j = 0; j < massiv.GetLength(1); j+=2)
    {
            massiv[i,j]=massiv[i,j]*massiv[i,j];  
    }
}Console.WriteLine();

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        Console.Write(massiv[i,j] +" ");
    }Console.WriteLine();
}