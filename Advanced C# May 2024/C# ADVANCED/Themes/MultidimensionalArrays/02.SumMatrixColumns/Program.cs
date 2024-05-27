int[] mSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = mSize[0];
int cols = mSize[1];

int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] values = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = values[col];
    }
}
                       // matrix.GetLength(0)
for (int col = 0; col < cols; col++)
{
    int sum = 0;
                            // matrix.GetLength(1)
    for (int row = 0; row < rows; row++)
    {
        sum += matrix[row, col];
    }
    System.Console.WriteLine(sum);
}