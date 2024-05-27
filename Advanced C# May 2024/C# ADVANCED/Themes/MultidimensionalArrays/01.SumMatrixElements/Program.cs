

int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];
int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}
int sum = 0;
foreach (int item in matrix)
{
    sum += item;
}
Console.WriteLine(input[0]);
Console.WriteLine(input[1]);
Console.WriteLine(sum);