// 52
int[ , ] massiv = new int[3,4];
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
int sum = 0;
int min = massiv.GetLength(0);

if(min>massiv.GetLength(1)){
min=massiv.GetLength(1);
}
for (int i = 0; i < min; i++){
    sum=sum+ massiv[i,i];
}Console.WriteLine(sum);



