int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];
//i=row, j=col
for (int i = 0; i < size; i++)
{
    string[] row = Console.ReadLine().Split();
    for (int j = 0; j < size; j++)
    {
        matrix[i, j] = int.Parse(row[j]);
    }
}
int sum = 0;
for (int i = 0; i < size; i++)
{
    //matrix[i, i] - diagonal,[0,0][1,1][2,2]..
    sum += matrix[i, i];
}
Console.WriteLine(sum);