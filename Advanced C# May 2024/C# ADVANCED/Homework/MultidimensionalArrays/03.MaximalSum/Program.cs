using System.ComponentModel.DataAnnotations;

int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[,] matrix = new int[size[0], size[1]];
int Msum = int.MinValue;
int indexRow = 0;
int indexCol = 0;
for (int i = 0; i < size[0]; i++)
{
    int[] elements = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = elements[j];
    }
}
//въртим до предпоследните 2 от ляво на дясно
for (int i = 0; i < matrix.GetLength(0) - 2; i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 2; j++)
    {
        int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
        if (sum > Msum)
        {
            Msum = sum;
            indexRow = i;
            indexCol = j;
        }
    }
}

System.Console.WriteLine($"Sum = {Msum}");
for (int i = indexRow; i < indexRow + 3; i++)
{
    for (int j = indexCol; j < indexCol + 3; j++)
    {
        System.Console.Write(matrix[i, j] + " ");
    }
    System.Console.WriteLine();
}