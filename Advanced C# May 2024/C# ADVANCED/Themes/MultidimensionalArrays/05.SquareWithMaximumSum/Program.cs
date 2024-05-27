int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
for (int i = 0; i < size[0]; i++)
{
    int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = line[j];
    }
}
int maxSum = int.MinValue;
int maxSumRow = 0;
int maxSumCol = 0;
for (int i = 0; i < size[0] - 1; i++)
{
    for (int j = 0; j < size[1] - 1; j++)
    {
        int sum =
        //up left        up right
         matrix[i, j] + matrix[i, j + 1] +
         //down left        down right
         matrix[i + 1, j] + matrix[i + 1, j + 1];
        if (sum > maxSum)
        {
            maxSum = sum;
            maxSumRow = i;
            maxSumCol = j;
        }
    }
}
Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol + 1]}");
Console.WriteLine($"{matrix[maxSumRow + 1, maxSumCol]} {matrix[maxSumRow + 1, maxSumCol + 1]}");
Console.WriteLine(maxSum);