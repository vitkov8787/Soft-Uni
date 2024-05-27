int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

char[,] matrix = new char[size[0], size[1]];
int count = 0;
for (int i = 0; i < size[0]; i++)
{
    //string[] elements = Console.ReadLine().Split(' ');
    char[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < size[1]; j++)
    {
        matrix[i, j] = elements[j];
        // matrix[i, j] = elements[j][0];
    }
}
for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        if ((matrix[row, col] == matrix[row + 1, col]) &&
        (matrix[row, col + 1] == matrix[row + 1, col + 1]) &&
        (matrix[row, col] == matrix[row + 1, col + 1])) count++;


    }
}
System.Console.WriteLine(count);